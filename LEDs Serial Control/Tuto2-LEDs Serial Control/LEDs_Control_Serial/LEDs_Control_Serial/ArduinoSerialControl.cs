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

namespace LEDs_Control_Serial
{
    public partial class ArduinoSerialControl : Form
    {
        bool ArduinoConnected = false;
        bool HandshakeStatus = false;

        String serialIn = "";
        SerialPort ArduinoPort;
        
        public static int NumCommands = 0;
        

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        public ArduinoSerialControl()
        {
            InitializeComponent();
            DisableControls(); 

           
        }

        private void ArduinoSerialControl_Load(object sender, EventArgs e)
        {
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            ScanSerialPorts();
        }

        private void ScanSerialPorts() {

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
        
        public void AddDataMethod(String myString)
        {
            FromArduino.AppendText(myString);
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

            if (ArduinoConnected  && HandshakeStatus)
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
            ArduinoPort.Open();
            ArduinoConnected = true;
            ArduinoPort.DiscardInBuffer();
            ArduinoPort.Write("#INIT\n");

        }

       
        private void SerialDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            string s = (sender as SerialPort).ReadExisting();
            serialIn += s;

            FromArduino.Invoke(this.myDelegate, new Object[] { serialIn});

            if (serialIn.Contains("COMU_OK"))
            {
                HandshakeStatus = true;
                
                //MessageBox.Show("Communication succeeded!");
            } 

            Console.WriteLine("Serial In (rh) is: " + serialIn);

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
            Led1.Checked = false;
            Led2.Checked = false;
            Led3.Checked = false;
            MessageBoxArduino.Text = "";
            FromArduino.Text = "";
            FromArduino.Enabled = false;
            countNumber.Text = "0";
        }
        
        private void DisableControls()
        {
            // Leds
            Led1.Enabled = false;
            Led2.Enabled = false;
            Led3.Enabled = false;
            SendString.Enabled = false;
            clearDisplay.Enabled = false;
            MessageBoxArduino.Enabled = false;

        }

        private void EnableControls()
        {
            // Leds
            Led1.Enabled = true;
            Led2.Enabled = true;
            Led3.Enabled = true;
            FromArduino.Enabled = true;
            clearDisplay.Enabled = true;

            SendString.Enabled = true;
            MessageBoxArduino.Enabled = true;

            SerialConnect.Text = "Disengage";
        }


        private void ArduinoSerialControl_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Led1_Click(object sender, EventArgs e)
        {
            if (HandshakeStatus)
            {
                if (Led1.Checked)
                {
                    ArduinoPort.Write("#LED0_ON\n");
                    
                }
                else
                {

                    ArduinoPort.Write("#LED0_OFF\n");
                    
                }
            }
        }

        private void Led2_Click(object sender, EventArgs e)
        {
            if (HandshakeStatus)
            {
                if (Led2.Checked)
                {
                    ArduinoPort.Write("#LED1_ON\n");
                    
                }
                else
                {

                    ArduinoPort.Write("#LED1_OFF\n");
                    
                }
            }
        }

        private void Led3_Click(object sender, EventArgs e)
        {
            if (HandshakeStatus)
            {
                if (Led3.Checked)
                {
                    ArduinoPort.Write("#LED2_ON\n");
                    
                }
                else
                {

                    ArduinoPort.Write("#LED2_OFF\n");
                   
                }
            }
        }

        private void SendString_Click(object sender, EventArgs e)
        {
            if (HandshakeStatus)
            {
                if (MessageBoxArduino.Text.Length <= 16)
                {
                    ArduinoPort.Write("#TEXT_" + MessageBoxArduino.Text + "\n");
                }
                else
                {
                    MessageBox.Show("The message should be 16 characters", "Message Overload", MessageBoxButtons.OKCancel);
                }
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

        private void Led3_EnabledChanged(object sender, EventArgs e)
        {

            if (HandshakeStatus)
            {
                ArduinoPort.Write("#LED2_OFF\n");
            }
        }

        private void Led2_EnabledChanged(object sender, EventArgs e)
        {
            if (HandshakeStatus)
            {
                ArduinoPort.Write("#LED1_OFF\n");
            }
        }

        private void Led1_EnabledChanged(object sender, EventArgs e)
        {
            if (HandshakeStatus)
            {
                ArduinoPort.Write("#LED0_OFF\n");
            }
        }

        private void MessageBoxArduino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ArduinoPort.Write("#TEXT_" + MessageBoxArduino.Text + "\n");

            }
        }

        private void SerialPorts_Click(object sender, EventArgs e)
        {
            SerialPorts.Items.Clear();
            ScanSerialPorts();
        }

        private void FromArduino_TextChanged(object sender, EventArgs e)
        {
            NumCommands++;
            FromArduino.ScrollToCaret();
            countNumber.Text = NumCommands.ToString();
        }

        private void clearDisplay_Click(object sender, EventArgs e)
        {
            FromArduino.Text = "";
            NumCommands = 0;
            countNumber.Text = NumCommands.ToString();
        }
    }
}
