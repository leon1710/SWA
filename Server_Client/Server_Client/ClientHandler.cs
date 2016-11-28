using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Client
{
    public class ClientHandler
    {
        byte[] buffer = new byte[512];
        Socket clientSocket;
        Informer inform;

        public Socket ClientSocket
        {
            get
            {
                return clientSocket;
            }

            private set
            {
                clientSocket = value;
            }
        }
        public ClientHandler(Socket socket, Informer inform)
        {
            this.ClientSocket = socket;
            this.inform = inform;
            ThreadPool.QueueUserWorkItem(ReceiveData);
        }

        public void SendMessage(string message)
        {
            try
            {
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
            catch (Exception e)
            {
                Console.WriteLine("Client not connected!");
            }
        }

        private void ReceiveData(object o)
        {
            int length;
            String message;
            Console.WriteLine("Start receiving...");
            while (true)
            {
                do
                {
                    length = ClientSocket.Receive(buffer);
                    message = Encoding.UTF8.GetString(buffer, 0, length);
                } while (!message.Contains("\r\n"));
                
                inform(message, clientSocket);
                Console.Write(message);
                message = "";
                
                
            }
        }
    }
}
