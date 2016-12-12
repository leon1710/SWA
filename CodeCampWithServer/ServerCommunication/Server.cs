using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCommunication
{
    public class Server
    {
        /*
         Socket
         Binding
         Accepting
         ClientHandling mit Recieve
         
         */

        private Action<string> update;
        private string ip;
        private int port;
        private Socket serversocket;
        private List<ClientHandler> clients = new List<ClientHandler>();


        public Server(string ip, int port, Action<string> update)
        {
            this.ip = ip;
            this.port = port;
            this.update = update;

            serversocket = new Socket(
               AddressFamily.InterNetwork,
               SocketType.Stream,
               ProtocolType.Tcp);

            serversocket.Bind(new IPEndPoint(IPAddress.Parse(ip), port));
            serversocket.Listen(5);
            //Console.WriteLine("ready to accept clients....");
            ThreadPool.QueueUserWorkItem(StartAccepting);
        }

        private void StartAccepting(object state)
        {
            //Informer inf = new Informer(SendToAllClients);
            while (true)
            {
                clients.Add(new ClientHandler(serversocket.Accept(), update));
                Console.WriteLine("client " + clients.Count + " accepted!");
            }
        }
    }
}
