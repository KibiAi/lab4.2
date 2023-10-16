using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Server : Computer, IConnectable
    {
        public int MaxConnections { get; set; }

        public Server(string ipAddress, int power, string os, int maxConnections)
            : base(ipAddress, power, os)
        {
            MaxConnections = maxConnections;
        }

        public void Connect(Computer otherComputer)
        {
            Console.WriteLine($"Сервер {IPAddress} під'єднався до {otherComputer.IPAddress}.");
        }

        public void Disconnect(Computer otherComputer)
        {
            Console.WriteLine($"Сервер {IPAddress} від'єднався від {otherComputer.IPAddress}.");
        }

        public void TransferData(Computer otherComputer, string data)
        {
            Console.WriteLine($"Сервер {IPAddress} передав дані користувачу {otherComputer.IPAddress}: {data}");
        }
    }
}
