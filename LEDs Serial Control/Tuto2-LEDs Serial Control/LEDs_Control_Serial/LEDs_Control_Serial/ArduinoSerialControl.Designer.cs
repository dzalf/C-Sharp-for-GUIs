namespace LEDs_Control_Serial
{
    partial class ArduinoSerialControl
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
            this.TextSendGroup = new System.Windows.Forms.GroupBox();
            this.SendString = new System.Windows.Forms.Button();
            this.MessageBoxArduino = new System.Windows.Forms.TextBox();
            this.LedControlGroup = new System.Windows.Forms.GroupBox();
            this.Led3 = new System.Windows.Forms.CheckBox();
            this.Led2 = new System.Windows.Forms.CheckBox();
            this.Led1 = new System.Windows.Forms.CheckBox();
            this.SerialPortsGroup = new System.Windows.Forms.GroupBox();
            this.SerialPorts = new System.Windows.Forms.ComboBox();
            this.SerialConnect = new System.Windows.Forms.Button();
            this.ReadArduino = new System.Windows.Forms.GroupBox();
            this.countNumber = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.clearDisplay = new System.Windows.Forms.Button();
            this.FromArduino = new System.Windows.Forms.RichTextBox();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TextSendGroup.SuspendLayout();
            this.LedControlGroup.SuspendLayout();
            this.SerialPortsGroup.SuspendLayout();
            this.ReadArduino.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextSendGroup
            // 
            this.TextSendGroup.Controls.Add(this.SendString);
            this.TextSendGroup.Controls.Add(this.MessageBoxArduino);
            this.TextSendGroup.Location = new System.Drawing.Point(20, 50);
            this.TextSendGroup.Name = "TextSendGroup";
            this.TextSendGroup.Size = new System.Drawing.Size(280, 132);
            this.TextSendGroup.TabIndex = 0;
            this.TextSendGroup.TabStop = false;
            this.TextSendGroup.Text = "Write Text to Arduino LCD";
            // 
            // SendString
            // 
            this.SendString.Location = new System.Drawing.Point(69, 70);
            this.SendString.Name = "SendString";
            this.SendString.Size = new System.Drawing.Size(140, 46);
            this.SendString.TabIndex = 1;
            this.SendString.Text = "Send Message";
            this.SendString.UseVisualStyleBackColor = true;
            this.SendString.Click += new System.EventHandler(this.SendString_Click);
            // 
            // MessageBoxArduino
            // 
            this.MessageBoxArduino.AcceptsReturn = true;
            this.MessageBoxArduino.Location = new System.Drawing.Point(15, 30);
            this.MessageBoxArduino.MaxLength = 16;
            this.MessageBoxArduino.Name = "MessageBoxArduino";
            this.MessageBoxArduino.Size = new System.Drawing.Size(244, 20);
            this.MessageBoxArduino.TabIndex = 0;
            this.MessageBoxArduino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBoxArduino_KeyDown);
            // 
            // LedControlGroup
            // 
            this.LedControlGroup.Controls.Add(this.Led3);
            this.LedControlGroup.Controls.Add(this.Led2);
            this.LedControlGroup.Controls.Add(this.Led1);
            this.LedControlGroup.Location = new System.Drawing.Point(330, 232);
            this.LedControlGroup.Name = "LedControlGroup";
            this.LedControlGroup.Size = new System.Drawing.Size(249, 67);
            this.LedControlGroup.TabIndex = 1;
            this.LedControlGroup.TabStop = false;
            this.LedControlGroup.Text = "LEDs Control";
            // 
            // Led3
            // 
            this.Led3.AutoSize = true;
            this.Led3.Location = new System.Drawing.Point(174, 31);
            this.Led3.Name = "Led3";
            this.Led3.Size = new System.Drawing.Size(56, 17);
            this.Led3.TabIndex = 2;
            this.Led3.Text = "LED 3";
            this.Led3.UseVisualStyleBackColor = true;
            this.Led3.EnabledChanged += new System.EventHandler(this.Led3_EnabledChanged);
            this.Led3.Click += new System.EventHandler(this.Led3_Click);
            // 
            // Led2
            // 
            this.Led2.AutoSize = true;
            this.Led2.Location = new System.Drawing.Point(99, 30);
            this.Led2.Name = "Led2";
            this.Led2.Size = new System.Drawing.Size(56, 17);
            this.Led2.TabIndex = 1;
            this.Led2.Text = "LED 2";
            this.Led2.UseVisualStyleBackColor = true;
            this.Led2.EnabledChanged += new System.EventHandler(this.Led2_EnabledChanged);
            this.Led2.Click += new System.EventHandler(this.Led2_Click);
            // 
            // Led1
            // 
            this.Led1.AutoSize = true;
            this.Led1.Location = new System.Drawing.Point(30, 31);
            this.Led1.Name = "Led1";
            this.Led1.Size = new System.Drawing.Size(56, 17);
            this.Led1.TabIndex = 0;
            this.Led1.Text = "LED 1";
            this.Led1.UseVisualStyleBackColor = true;
            this.Led1.EnabledChanged += new System.EventHandler(this.Led1_EnabledChanged);
            this.Led1.Click += new System.EventHandler(this.Led1_Click);
            // 
            // SerialPortsGroup
            // 
            this.SerialPortsGroup.Controls.Add(this.SerialPorts);
            this.SerialPortsGroup.Controls.Add(this.SerialConnect);
            this.SerialPortsGroup.Location = new System.Drawing.Point(20, 214);
            this.SerialPortsGroup.Name = "SerialPortsGroup";
            this.SerialPortsGroup.Size = new System.Drawing.Size(280, 86);
            this.SerialPortsGroup.TabIndex = 3;
            this.SerialPortsGroup.TabStop = false;
            this.SerialPortsGroup.Text = "Serial Ports";
            // 
            // SerialPorts
            // 
            this.SerialPorts.AllowDrop = true;
            this.SerialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPorts.FormattingEnabled = true;
            this.SerialPorts.Location = new System.Drawing.Point(15, 28);
            this.SerialPorts.Name = "SerialPorts";
            this.SerialPorts.Size = new System.Drawing.Size(119, 24);
            this.SerialPorts.TabIndex = 1;
            this.SerialPorts.Click += new System.EventHandler(this.SerialPorts_Click);
            // 
            // SerialConnect
            // 
            this.SerialConnect.Location = new System.Drawing.Point(150, 19);
            this.SerialConnect.Name = "SerialConnect";
            this.SerialConnect.Size = new System.Drawing.Size(109, 55);
            this.SerialConnect.TabIndex = 0;
            this.SerialConnect.Text = "Engage COM";
            this.SerialConnect.UseVisualStyleBackColor = true;
            this.SerialConnect.Click += new System.EventHandler(this.SerialConnect_Click);
            // 
            // ReadArduino
            // 
            this.ReadArduino.Controls.Add(this.countNumber);
            this.ReadArduino.Controls.Add(this.countLabel);
            this.ReadArduino.Controls.Add(this.clearDisplay);
            this.ReadArduino.Controls.Add(this.FromArduino);
            this.ReadArduino.Location = new System.Drawing.Point(330, 28);
            this.ReadArduino.Name = "ReadArduino";
            this.ReadArduino.Size = new System.Drawing.Size(253, 198);
            this.ReadArduino.TabIndex = 4;
            this.ReadArduino.TabStop = false;
            this.ReadArduino.Text = "Sent from Arduino";
            // 
            // countNumber
            // 
            this.countNumber.AutoSize = true;
            this.countNumber.Location = new System.Drawing.Point(62, 172);
            this.countNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countNumber.Name = "countNumber";
            this.countNumber.Size = new System.Drawing.Size(14, 13);
            this.countNumber.TabIndex = 9;
            this.countNumber.Text = "#";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(13, 172);
            this.countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "Count:";
            // 
            // clearDisplay
            // 
            this.clearDisplay.Location = new System.Drawing.Point(166, 165);
            this.clearDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearDisplay.Name = "clearDisplay";
            this.clearDisplay.Size = new System.Drawing.Size(81, 28);
            this.clearDisplay.TabIndex = 7;
            this.clearDisplay.Text = "Clear";
            this.clearDisplay.UseVisualStyleBackColor = true;
            this.clearDisplay.Click += new System.EventHandler(this.clearDisplay_Click);
            // 
            // FromArduino
            // 
            this.FromArduino.Location = new System.Drawing.Point(6, 23);
            this.FromArduino.Name = "FromArduino";
            this.FromArduino.Size = new System.Drawing.Size(242, 137);
            this.FromArduino.TabIndex = 6;
            this.FromArduino.Text = "";
            this.FromArduino.TextChanged += new System.EventHandler(this.FromArduino_TextChanged);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(618, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ArduinoSerialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 319);
            this.Controls.Add(this.ReadArduino);
            this.Controls.Add(this.SerialPortsGroup);
            this.Controls.Add(this.LedControlGroup);
            this.Controls.Add(this.TextSendGroup);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ArduinoSerialControl";
            this.Text = "Arduino Serial Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArduinoSerialControl_FormClosing);
            this.Load += new System.EventHandler(this.ArduinoSerialControl_Load);
            this.TextSendGroup.ResumeLayout(false);
            this.TextSendGroup.PerformLayout();
            this.LedControlGroup.ResumeLayout(false);
            this.LedControlGroup.PerformLayout();
            this.SerialPortsGroup.ResumeLayout(false);
            this.ReadArduino.ResumeLayout(false);
            this.ReadArduino.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TextSendGroup;
        private System.Windows.Forms.Button SendString;
        private System.Windows.Forms.TextBox MessageBoxArduino;
        private System.Windows.Forms.GroupBox LedControlGroup;
        private System.Windows.Forms.CheckBox Led3;
        private System.Windows.Forms.CheckBox Led2;
        private System.Windows.Forms.CheckBox Led1;
        private System.Windows.Forms.GroupBox SerialPortsGroup;
        private System.Windows.Forms.Button SerialConnect;
        private System.Windows.Forms.GroupBox ReadArduino;
        private System.Windows.Forms.ComboBox SerialPorts;
        private System.Windows.Forms.RichTextBox FromArduino;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button clearDisplay;
        private System.Windows.Forms.Label countNumber;
        private System.Windows.Forms.Label countLabel;
    }
}

