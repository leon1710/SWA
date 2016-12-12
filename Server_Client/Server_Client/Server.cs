using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Client
{
    public class Server
    {
        Socket serversocket;
        List<ClientHandler> clients = new List<ClientHandler>();
        Informer inform;
        public Server(string ipaddress, int port)
        {
            //inform = new Informer(SendToAllClients);
            serversocket = new Socket(
               AddressFamily.InterNetwork,
               SocketType.Stream,
               ProtocolType.Tcp);

            serversocket.Bind(new IPEndPoint(IPAddress.Parse(ipaddress), port));
            serversocket.Listen(5);
            Console.WriteLine("ready to accept clients....");
            ThreadPool.QueueUserWorkItem(new WaitCallback(StartAccepting), null);
        }

        private void StartAccepting(object state)
        {
            Informer inf = new Informer(SendToAllClients);
            while (true)
            {
                clients.Add(new ClientHandler(serversocket.Accept(), inf));
                Console.WriteLine("client " + clients.Count + " accepted!");
            }
        }

        public void SendToAllClients(string message, Socket initiator)
        {
            foreach (var item in clients)
            {
                if (initiator != item.ClientSocket)
                {
                    item.SendMessage(message);
                }
            }
        }
    }
}
