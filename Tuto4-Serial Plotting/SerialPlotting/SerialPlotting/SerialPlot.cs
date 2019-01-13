using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using rtChart;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialPlotting
{
    public partial class SerialPlot : Form
    {

        private bool ArduinoConnected = false;
        private bool HandshakeStatus = false;

        private int xLim;
        String serialIn;

        SerialPort ArduinoPort;
        kayChart dataFreq;

        DateTime timeStamp;

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        public SerialPlot()
        {
            InitializeComponent();
            DisableControls();

            this.plotChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            plotChart.Series[0].XValueType = ChartValueType.DateTime;
            timer1.Start();
        }


        private void SerialPlot_Load(object sender, EventArgs e)
        {
            xLim = YLimBar.Value;
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            ScanSerialPorts();
            dataFreq = new kayChart(plotChart, xLim);
            dataFreq.serieName = "serialFreqIn";

        }

        private void AddDataMethod(string myString)
        {
            FromArduino.AppendText(myString);
        }

        private void ScanSerialPorts()
        {

            String[] ports;

            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {

                SerialPorts.Items.Add(port);

                if (ports[0] != null)
                {
                    SerialPorts.SelectedItem = ports[0];

                }

            }
        }

        private void SerialConnect_Click(object sender, EventArgs e)
        {
            if (!ArduinoConnected)
            {
                QueryCOM();


                if (HandshakeStatus)
                {
                    Console.WriteLine("I received COMU_OK!");
                    Console.WriteLine("Sucess!");

                }
                EnableControls();
            }

            if (ArduinoConnected && HandshakeStatus)
            {
                DisconnectArduino();
            }
        }

        private void QueryCOM()
        {

            string PortSelected = SerialPorts.GetItemText(SerialPorts.SelectedItem);

            ArduinoPort = new SerialPort(PortSelected, 115200, Parity.None, 8, StopBits.One);
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedHandler);
            ArduinoPort.DtrEnable = false;
            ArduinoPort.Handshake = Handshake.None;
            try {

                ArduinoPort.Open();
                ArduinoConnected = true;
                ArduinoPort.DiscardInBuffer();
                ArduinoPort.Write("#INIT\n");

            }
            catch
            {
                MessageBox.Show("The selected Port is Opened. Verify your connections", "COM Port failed", MessageBoxButtons.OKCancel);
            }
            

            }

        List<DateTime> TimeList = new List<DateTime>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeStamp  = DateTime.Now;
            TimeList.Add(timeStamp);


        }
        private void SerialDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            string s = (sender as SerialPort).ReadLine();
            serialIn += s;
            
            FromArduino.Invoke(this.myDelegate, new Object[] { "Datum: " + serialIn });
            string timeStamp = GetTimeStamp(DateTime.Now);
            Console.WriteLine("time Stamp: " + timeStamp);


            if (serialIn.Contains("COMU_OK"))
            {
                HandshakeStatus = true;
                Console.WriteLine("Communication successful! ");
            }
            else
            {
                // Updatin chart via keyChart functiuons


                bool result = Double.TryParse(serialIn, out double dataPoint);


                if (result)
                {
                    dataFreq.TriggeredUpdate(dataPoint);
                   // plotChart.Series[0].Points.AddXY(timeStamp, dataPoint);
                    
                }
            }

            Console.WriteLine("Serial In is: " + serialIn);

            ArduinoPort.DiscardInBuffer();
            ArduinoPort.DiscardOutBuffer();
            serialIn = "";
        }

      

        private void DisconnectArduino()
        {


            DefaultState();
            DisableControls();

            ArduinoPort.Write("#STOP\n");
            SerialConnect.Text = "Engage COM";
            ArduinoConnected = false;
            HandshakeStatus = false;

            ArduinoPort.Close();
        }

        private void DefaultState()
        {

            FromArduino.Text = "";
            FromArduino.Enabled = false;
            
        }

        private void DisableControls()
        {
                        
            clearText.Enabled = false;         

        }

        private void EnableControls()
        {
                   
            FromArduino.Enabled = true;
            clearText.Enabled = true;

            SerialConnect.Text = "Disengage";
        }

        private void SerialPlot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ArduinoConnected)
            {

                ArduinoPort.Write("#STOP\n");
                ArduinoPort.DiscardInBuffer();
                ArduinoPort.DiscardInBuffer();
                ArduinoPort.Close();
                ArduinoConnected = false;

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ArduinoConnected && HandshakeStatus)
            {

                DisconnectArduino();
            }
            this.Close();
        }

        private void SerialPorts_Click(object sender, EventArgs e)
        {
            SerialPorts.Items.Clear();
            ScanSerialPorts();
        }

        private void FromArduino_TextChanged(object sender, EventArgs e)
        {
            FromArduino.SelectionStart = FromArduino.Text.Length;
            FromArduino.ScrollToCaret();
        }

        private void clearText_Click(object sender, EventArgs e)
        {
            FromArduino.Text = "";
        }

        private void YLimBar_ValueChanged(object sender, EventArgs e)
        {
            plotChart.ChartAreas[0].AxisY.Maximum = YLimBar.Value;
            plotChart.ChartAreas[0].AxisY.Minimum = YLimBar.Minimum;
        }

        public static String GetTimeStamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }
    }
}
