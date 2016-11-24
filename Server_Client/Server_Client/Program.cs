using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket serverSocket = new Socket(
                AddressFamily.InterNetwork, 
                SocketType.Stream,
                ProtocolType.Tcp);

            //Welche IP und welchen Port wollen wir abhören
            serverSocket.Bind(new IPEndPoint(IPAddress.Loopback, 9080));

            //wie viele Clients akzptieren wir in Waitinglist
            serverSocket.Listen(5);

            //Verbindung ist aufgebaut
            Console.WriteLine("Ready to accept Clients");
            Socket clientSocket = serverSocket.Accept();
            Console.WriteLine("Client accepted!");

            //Nachricht die an Client gesendet wird
            string message= "Welcome Client!";
            clientSocket.Send(Encoding.UTF8.GetBytes(message));

            byte[] buffer = new byte[512];
            int length;

            while (true)
            {
                //message = Console.ReadLine();
                //Encoding weil Send() nur Byte oder int entgegennimmt
                //clientSocket.Send(Encoding.UTF8.GetBytes(message));
                length = clientSocket.Receive(buffer);
                Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, length));
            }

        }
    }
}
