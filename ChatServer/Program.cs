using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ChatServer
{
    class Program
    {
        static List<TcpClient> _clients;
        static TcpListener _listener;
        static void Main(string[] args)
        {
            _clients = new List<TcpClient>();
            _listener = new TcpListener(IPAddress.Any, 8888);
            Listen(); 
        }
        static void Listen()
        {
            _listener.Start();
            while (true)
            {
                _clients.Add(_listener.AcceptTcpClient());
                Console.WriteLine("New People is comming");
            }
        }
    }
}
