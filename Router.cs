using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Router : Computer, IConnectable
    {
        public List<Computer> ConnectedComputers { get; set; }

        public Router(string ipAddress, int power, string os)
            : base(ipAddress, power, os)
        {
            ConnectedComputers = new List<Computer>();
        }

        public void Connect(Computer otherComputer)
        {
            ConnectedComputers.Add(otherComputer);
            Console.WriteLine($"Маршрутизатор {IPAddress} під'єднав {otherComputer.IPAddress}.");
        }

        public void Disconnect(Computer otherComputer)
        {
            ConnectedComputers.Remove(otherComputer);
            Console.WriteLine($"Маршрутизатор {IPAddress} від'єднав {otherComputer.IPAddress}.");
        }

        public void TransferData(Computer otherComputer, string data)
        {
            Console.WriteLine($"Маршрутизатор {IPAddress} передав дані від {IPAddress} до {otherComputer.IPAddress}: {data}");
        }
    }
}
