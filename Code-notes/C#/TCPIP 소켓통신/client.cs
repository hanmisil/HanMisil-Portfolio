using System;
using System.Text;
using System.Net.Sockets;

namespace ServerClientSample
{
    class Client
    {
        public delegate void ClientCallback(string msg);
        
        TcpClient client;
        NetworkStream stream;
        ClientCallback callback;

        public Client(ClientCallback callbackDelegate)
        {
            callback = callbackDelegate;
        }

        public bool Connect(string ip, string port)
        {
            try
            {
                client = new TcpClient(ip, Convert.ToInt32(port));
                stream = client.GetStream();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void Send(string msg)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);

            stream.Write(buffer, 0, buffer.Length);
        }

        
        public void Recv()
        {
            byte[] buffer = new byte[1024];

            while (true)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                callback(response);
            }

        }



        public void Disconnect()
        {
            stream.Close();
            client.Close();
        }
        
    }
}
