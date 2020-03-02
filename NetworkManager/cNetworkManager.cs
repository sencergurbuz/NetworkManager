using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManager
{
    public class cNetworkManager
    {
        private UdpClient udpClient;

        public delegate void delOnRecieved(byte[] bytes);

        public event delOnRecieved onRecieved;

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
                        Revieve();
                    }
                    else
                    {
                        udpClient = new UdpClient(Adress, Port);
                    }
                    break;
                case Protocol.TCP:
                    break;
                default:
                    break;
            }

            isPortValid = true;
        }

        private void Revieve() 
        {
            udpClient.BeginReceive(callback, null);
        }

        private void callback(IAsyncResult ar)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, Port);
            byte[] bytes = udpClient.EndReceive(ar, ref endPoint);
            onRecieved.Invoke(bytes);
            Revieve();
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
