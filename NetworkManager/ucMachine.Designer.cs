namespace NetworkManager
{
    partial class ucMachine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxRecieve = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTargetAdress = new System.Windows.Forms.TextBox();
            this.textBoxTargetPort = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonListen = new System.Windows.Forms.Button();
            this.buttonNotListen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(234, 0);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(85, 28);
            this.buttonDisconnect.TabIndex = 8;
            this.buttonDisconnect.Text = "Close";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 28);
            this.panel1.TabIndex = 9;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonConnect.Location = new System.Drawing.Point(138, 0);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 28);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSend.Location = new System.Drawing.Point(0, 0);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(234, 27);
            this.textBoxSend.TabIndex = 10;
            // 
            // buttonSend
            // 
            this.buttonSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSend.Location = new System.Drawing.Point(234, 0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(85, 27);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxRecieve
            // 
            this.textBoxRecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRecieve.Location = new System.Drawing.Point(5, 50);
            this.textBoxRecieve.Multiline = true;
            this.textBoxRecieve.Name = "textBoxRecieve";
            this.textBoxRecieve.Size = new System.Drawing.Size(319, 187);
            this.textBoxRecieve.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRecieve);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(329, 242);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxSend);
            this.panel5.Controls.Add(this.buttonSend);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 18);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel5.Size = new System.Drawing.Size(319, 32);
            this.panel5.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(329, 80);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Machine";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxTargetAdress);
            this.panel4.Controls.Add(this.textBoxTargetPort);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 28);
            this.panel4.TabIndex = 17;
            // 
            // textBoxTargetAdress
            // 
            this.textBoxTargetAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTargetAdress.Location = new System.Drawing.Point(0, 0);
            this.textBoxTargetAdress.Name = "textBoxTargetAdress";
            this.textBoxTargetAdress.Size = new System.Drawing.Size(234, 20);
            this.textBoxTargetAdress.TabIndex = 13;
            this.textBoxTargetAdress.Text = "127.0.0.1";
            // 
            // textBoxTargetPort
            // 
            this.textBoxTargetPort.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxTargetPort.Location = new System.Drawing.Point(234, 0);
            this.textBoxTargetPort.Name = "textBoxTargetPort";
            this.textBoxTargetPort.Size = new System.Drawing.Size(85, 20);
            this.textBoxTargetPort.TabIndex = 14;
            this.textBoxTargetPort.Text = "1101";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonListen);
            this.panel3.Controls.Add(this.buttonNotListen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 28);
            this.panel3.TabIndex = 18;
            // 
            // buttonListen
            // 
            this.buttonListen.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonListen.Location = new System.Drawing.Point(138, 0);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(96, 28);
            this.buttonListen.TabIndex = 9;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // buttonNotListen
            // 
            this.buttonNotListen.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNotListen.Enabled = false;
            this.buttonNotListen.Location = new System.Drawing.Point(234, 0);
            this.buttonNotListen.Name = "buttonNotListen";
            this.buttonNotListen.Size = new System.Drawing.Size(85, 28);
            this.buttonNotListen.TabIndex = 8;
            this.buttonNotListen.Text = "Close";
            this.buttonNotListen.UseVisualStyleBackColor = true;
            this.buttonNotListen.Click += new System.EventHandler(this.buttonNotListen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(329, 80);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local Machine";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBoxLocalPort);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 28);
            this.panel2.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "UDP";
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxLocalPort.Location = new System.Drawing.Point(234, 0);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(85, 20);
            this.textBoxLocalPort.TabIndex = 6;
            this.textBoxLocalPort.Text = "1100";
            // 
            // ucMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ucMachine";
            this.Size = new System.Drawing.Size(329, 402);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxRecieve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTargetAdress;
        private System.Windows.Forms.TextBox textBoxTargetPort;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Button buttonNotListen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxLocalPort;
    }
}
