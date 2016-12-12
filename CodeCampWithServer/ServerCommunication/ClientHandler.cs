using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCommunication
{
    public class ClientHandler
    {
        private Socket socket;
        private Action<string> update;
        private byte[] buffer = new byte[2048];

        public ClientHandler(Socket socket, Action<string> update)
        {
            this.socket = socket;
            this.update = update;
            ThreadPool.QueueUserWorkItem(StartReceiving);
        }

        private void StartReceiving(object state)
        {
            int length;
            String message = "";
            //Console.WriteLine("Start receiving...");
            while (true)
            {
               length = socket.Receive(buffer);
               message = Encoding.UTF8.GetString(buffer, 0, length);
               update(message);
               Console.Write(message);
               message = "";


            }
        }
    }
}
