namespace SerialPlotting
{
    partial class SerialPlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plotChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SerialConnect = new System.Windows.Forms.Button();
            this.SerialCOMGroup = new System.Windows.Forms.GroupBox();
            this.SerialPorts = new System.Windows.Forms.ComboBox();
            this.FromArduino = new System.Windows.Forms.RichTextBox();
            this.clearText = new System.Windows.Forms.Button();
            this.DataIn = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotGroup = new System.Windows.Forms.GroupBox();
            this.plotControls = new System.Windows.Forms.GroupBox();
            this.YLimBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plotChart)).BeginInit();
            this.SerialCOMGroup.SuspendLayout();
            this.DataIn.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.plotGroup.SuspendLayout();
            this.plotControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotChart
            // 
            chartArea1.Name = "ChartArea1";
            this.plotChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plotChart.Legends.Add(legend1);
            this.plotChart.Location = new System.Drawing.Point(19, 19);
            this.plotChart.Name = "plotChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "serialFreqIn";
            this.plotChart.Series.Add(series1);
            this.plotChart.Size = new System.Drawing.Size(499, 322);
            this.plotChart.TabIndex = 0;
            this.plotChart.Text = "Live Plot";
            // 
            // SerialConnect
            // 
            this.SerialConnect.Location = new System.Drawing.Point(45, 57);
            this.SerialConnect.Name = "SerialConnect";
            this.SerialConnect.Size = new System.Drawing.Size(75, 37);
            this.SerialConnect.TabIndex = 1;
            this.SerialConnect.Text = "Connect";
            this.SerialConnect.UseVisualStyleBackColor = true;
            this.SerialConnect.Click += new System.EventHandler(this.SerialConnect_Click);
            // 
            // SerialCOMGroup
            // 
            this.SerialCOMGroup.Controls.Add(this.SerialPorts);
            this.SerialCOMGroup.Controls.Add(this.SerialConnect);
            this.SerialCOMGroup.Location = new System.Drawing.Point(26, 338);
            this.SerialCOMGroup.Name = "SerialCOMGroup";
            this.SerialCOMGroup.Size = new System.Drawing.Size(167, 100);
            this.SerialCOMGroup.TabIndex = 2;
            this.SerialCOMGroup.TabStop = false;
            this.SerialCOMGroup.Text = "Serial COM";
            // 
            // SerialPorts
            // 
            this.SerialPorts.FormattingEnabled = true;
            this.SerialPorts.Location = new System.Drawing.Point(21, 30);
            this.SerialPorts.Name = "SerialPorts";
            this.SerialPorts.Size = new System.Drawing.Size(121, 21);
            this.SerialPorts.TabIndex = 2;
            this.SerialPorts.Click += new System.EventHandler(this.SerialPorts_Click);
            // 
            // FromArduino
            // 
            this.FromArduino.Location = new System.Drawing.Point(20, 30);
            this.FromArduino.Name = "FromArduino";
            this.FromArduino.Size = new System.Drawing.Size(160, 230);
            this.FromArduino.TabIndex = 4;
            this.FromArduino.Text = "";
            this.FromArduino.TextChanged += new System.EventHandler(this.FromArduino_TextChanged);
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(105, 266);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(75, 24);
            this.clearText.TabIndex = 5;
            this.clearText.Text = "Clear";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // DataIn
            // 
            this.DataIn.Controls.Add(this.FromArduino);
            this.DataIn.Controls.Add(this.clearText);
            this.DataIn.Location = new System.Drawing.Point(13, 24);
            this.DataIn.Name = "DataIn";
            this.DataIn.Size = new System.Drawing.Size(194, 296);
            this.DataIn.TabIndex = 6;
            this.DataIn.TabStop = false;
            this.DataIn.Text = "Incoming Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // plotGroup
            // 
            this.plotGroup.Controls.Add(this.plotControls);
            this.plotGroup.Controls.Add(this.plotChart);
            this.plotGroup.Location = new System.Drawing.Point(240, 28);
            this.plotGroup.Name = "plotGroup";
            this.plotGroup.Size = new System.Drawing.Size(536, 410);
            this.plotGroup.TabIndex = 8;
            this.plotGroup.TabStop = false;
            this.plotGroup.Text = "Plot Panel";
            // 
            // plotControls
            // 
            this.plotControls.Controls.Add(this.YLimBar);
            this.plotControls.Controls.Add(this.label1);
            this.plotControls.Location = new System.Drawing.Point(19, 348);
            this.plotControls.Name = "plotControls";
            this.plotControls.Size = new System.Drawing.Size(499, 56);
            this.plotControls.TabIndex = 3;
            this.plotControls.TabStop = false;
            this.plotControls.Text = "Plot Controls";
            // 
            // YLimBar
            // 
            this.YLimBar.Location = new System.Drawing.Point(32, 22);
            this.YLimBar.Maximum = 2000;
            this.YLimBar.Minimum = 100;
            this.YLimBar.Name = "YLimBar";
            this.YLimBar.Size = new System.Drawing.Size(120, 17);
            this.YLimBar.TabIndex = 1;
            this.YLimBar.Value = 150;
            this.YLimBar.ValueChanged += new System.EventHandler(this.YLimBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y-Limits";
            // 
            // SerialPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plotGroup);
            this.Controls.Add(this.DataIn);
            this.Controls.Add(this.SerialCOMGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SerialPlot";
            this.Text = "Serial Plot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialPlot_FormClosing);
            this.Load += new System.EventHandler(this.SerialPlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plotChart)).EndInit();
            this.SerialCOMGroup.ResumeLayout(false);
            this.DataIn.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.plotGroup.ResumeLayout(false);
            this.plotControls.ResumeLayout(false);
            this.plotControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart plotChart;
        private System.Windows.Forms.Button SerialConnect;
        private System.Windows.Forms.GroupBox SerialCOMGroup;
        private System.Windows.Forms.ComboBox SerialPorts;
        private System.Windows.Forms.RichTextBox FromArduino;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.GroupBox DataIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox plotGroup;
        private System.Windows.Forms.HScrollBar YLimBar;
        private System.Windows.Forms.GroupBox plotControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

