using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace NetworkManager
{
    public partial class ucMachine : UserControl
    {
        public int LocalPort
        {
            get
            {
                return MachineLocal.Port;
            }
            set
            {
                MachineLocal.Port = value;
                textBoxLocalPort.Text = value.ToString();

            }
        }

        public string TargetAdress
        {
            get
            {
                return MachineTarget.Adress;
            }
            set
            {
                MachineTarget.Adress = value;
                textBoxTargetAdress.Text = value.ToString();
            }
        }

        public int TargetPort
        {
            get
            {
                return MachineTarget.Port;
            }
            set
            {
                MachineTarget.Port = value;
                textBoxTargetPort.Text = value.ToString();
            }
        }

        private cNetworkManager MachineLocal = new cNetworkManager("127.0.0.1", 1000);

        private cNetworkManager MachineTarget = new cNetworkManager("127.0.0.1", 1000);

        public bool isTargetValid { get; set; }

        public ucMachine()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            MachineTarget = new cNetworkManager();
            MachineTarget.Role = enRole.Client;
            MachineTarget.Adress = textBoxTargetAdress.Text;
            MachineTarget.Port = Convert.ToInt32(textBoxTargetPort.Text);
            MachineTarget.protocol = Protocol.UDP;

            MachineTarget.Open();

            buttonDisconnect.Enabled = true;
            buttonConnect.Enabled = false;

            isTargetValid = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MachineTarget.Close();

            buttonDisconnect.Enabled = false;
            buttonConnect.Enabled = true;

            isTargetValid = false; ;
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            MachineLocal = new cNetworkManager();
            MachineLocal.Role = enRole.Server;
            MachineLocal.Port = Convert.ToInt32(textBoxLocalPort.Text);
            MachineLocal.protocol = Protocol.UDP;
            MachineLocal.onReceived += MachineLocal_onReceived;
            MachineLocal.Open();
            buttonListen.Enabled = false;
            buttonNotListen.Enabled = true;
        }

        private void buttonNotListen_Click(object sender, EventArgs e)
        {
            MachineLocal.Close();

            buttonListen.Enabled = true;
            buttonNotListen.Enabled = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] b = Encoding.ASCII.GetBytes(textBoxSend.Text);
            Send(b);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Send(byte[] bytes)
        {
            MachineTarget.Send(bytes);
        }

        private void MachineLocal_onReceived(byte[] bytes, System.Net.IPEndPoint sender)
        {
            if (textBoxRecieve.InvokeRequired)
            {
                textBoxRecieve.Invoke((MethodInvoker)(() => textBoxRecieve.Text = Encoding.ASCII.GetString(bytes)));

            }
            else
            {
                textBoxRecieve.Text = Encoding.ASCII.GetString(bytes);
            }
        }
    }
}
