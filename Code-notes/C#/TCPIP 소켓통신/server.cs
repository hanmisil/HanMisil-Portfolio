using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ServerClientSample
{
    class Server
    {
        public delegate void ServerConnectCallback(bool bStatus);
        public delegate void ServerCallback(string msg);

        TcpListener server;
        NetworkStream stream;
        TcpClient client;
        ServerConnectCallback callConnectback;
        ServerCallback callback;

        public Server(ServerConnectCallback callbackDelegate)
        {
            callConnectback = callbackDelegate;
        }

        public Server(ServerCallback callbackDelegate)
        {
            callback = callbackDelegate;
        }


        public bool Connect(string ip, string port)
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(ip);
                server = new TcpListener(localAddr, Convert.ToInt32(port));

                server.Start();
                return true;
            }
            catch
            {
                return false;
            }
        }
            

        public void ConnectThread()
        {
            while (true)
            {
                client = server.AcceptTcpClient();
                stream = client.GetStream();

                callConnectback(true);
            }
        }
        // InvalidOperationException
        // ObjectDisposedException

        public void RecvThread()
        {
            while (true)
            {
                client = server.AcceptTcpClient();
                stream = client.GetStream();

                Thread serverRecvThread = new Thread(new ThreadStart(Recv));
                serverRecvThread.Start();
            }
        }


        public void Send(string data)
        {
            //string response = "ACK: " + data;
            byte[] responseBuffer = Encoding.UTF8.GetBytes(data);
            stream.Write(responseBuffer, 0, responseBuffer.Length);
        }

        public void Recv()
        {
            byte[] buffer = new byte[1024];
            

            while (true)
            {
                if (stream != null)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (data != "")
                    {
                        callback(data);
                    }

                }
                
            }
        }

        public void Disconnect()
        {
            stream.Close();
            client.Close();

        }

    }
}
