namespace NetworkManagerTest
{
    partial class Form1
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
            NetworkManager.cNetworkManager cNetworkManager1 = new NetworkManager.cNetworkManager();
            NetworkManager.cNetworkManager cNetworkManager2 = new NetworkManager.cNetworkManager();
            this.ucMachine3 = new NetworkManager.ucMachine();
            this.SuspendLayout();
            // 
            // ucMachine3
            // 
            this.ucMachine3.isTargetValid = false;
            this.ucMachine3.Location = new System.Drawing.Point(198, 12);
            cNetworkManager1.Adress = "0.0.0.0";
            cNetworkManager1.isPortValid = false;
            cNetworkManager1.Port = 12345;
            cNetworkManager1.protocol = NetworkManager.Protocol.UDP;
            cNetworkManager1.Role = NetworkManager.enRole.Server;
            this.ucMachine3.MachineLocal = cNetworkManager1;
            cNetworkManager2.Adress = "0.0.0.0";
            cNetworkManager2.isPortValid = false;
            cNetworkManager2.Port = 12345;
            cNetworkManager2.protocol = NetworkManager.Protocol.UDP;
            cNetworkManager2.Role = NetworkManager.enRole.Server;
            this.ucMachine3.MachineTarget = cNetworkManager2;
            this.ucMachine3.Name = "ucMachine3";
            this.ucMachine3.Size = new System.Drawing.Size(329, 402);
            this.ucMachine3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucMachine3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NetworkManager.ucMachine ucMachine1;
        private NetworkManager.ucMachine ucMachine2;
        private NetworkManager.ucMachine ucMachine3;
    }
}

