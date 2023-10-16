using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Workstation : Computer, IConnectable
    {
        public string UserName { get; set; }

        public Workstation(string ipAddress, int power, string os, string userName)
            : base(ipAddress, power, os)
        {
            UserName = userName;
        }

        public void Connect(Computer otherComputer)
        {
            Console.WriteLine($"Користувач {UserName} під'єднався до {otherComputer.IPAddress}.");
        }

        public void Disconnect(Computer otherComputer)
        {
            Console.WriteLine($"Користувач {UserName} від'єднався від {otherComputer.IPAddress}.");
        }

        public void TransferData(Computer otherComputer, string data)
        {
            Console.WriteLine($"Користувач {UserName} передав дані на {otherComputer.IPAddress}: {data}");
        }
    }
}
