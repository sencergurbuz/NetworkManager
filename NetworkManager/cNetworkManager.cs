using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkManager
{
    public class cNetworkManager
    {
        private UdpClient udpClient;

        private SerialPort serialPort;

        public delegate void delOnReceived(byte[] bytes, IPEndPoint sender);

        public event delOnReceived onReceived;

        public string Adress { get; set; }

        public int Port { get; set; }

        public enRole Role { get; set; }

        public bool isPortValid { get; set; }

        public Protocol protocol { get; set; }

        public cNetworkManager()
        {
            Initilaize();
        }

        public cNetworkManager(string address, int port)
        {
            Adress = address;
            Port = port;
            Initilaize();
        }

        public cNetworkManager(string address, int port, enRole role)
        {
            Adress = address;
            Port = port;
            Role = role;
            Initilaize();
        }

        private void Initilaize()
        {
            udpClient = new UdpClient();
        }

        public void Open()
        {
            switch (protocol)
            {
                case Protocol.UDP:
                    
                    if (Role== enRole.Server)
                    {
                        udpClient = new UdpClient(Port);
                        Receive();
                    }
                    else
                    {
                        udpClient = new UdpClient(Adress, Port);
                    }
                    break;
                case Protocol.TCP:
                    break;

                case Protocol.SerialPort:
                    serialPort = new SerialPort();
                    serialPort.Open();
                    break;
                default:
                    break;
            }

            isPortValid = true;
        }

        private void Receive() 
        {
            udpClient.BeginReceive(callback, null);
        }

        private void callback(IAsyncResult ar)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, Port);

            if (udpClient.Client == null)
                return;

            byte[] bytes = udpClient.EndReceive(ar, ref endPoint);
            onReceived.Invoke(bytes, endPoint);
            Receive();
        }

        public void Close()
        {
            switch (protocol)
            {
                case Protocol.UDP:
                    udpClient.Close();
                    break;
                case Protocol.TCP:
                    break;
                case Protocol.SerialPort:
                    serialPort.Close();
                    break;
                default:
                    break;
            }

            isPortValid = false;
        }

        public void Send(byte[] bytes)
        {
            switch (protocol)
            {
                case Protocol.UDP:
                    udpClient.Send(bytes, bytes.Length);
                    break;
                case Protocol.TCP:
                    break;
                default:
                    break;
            }
        }
    }
}
