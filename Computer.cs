using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Computer
    {
        public string IPAddress { get; set; }
        public int Power { get; set; }
        public string OperatingSystem { get; set; }

        public Computer(string ipAddress, int power, string os)
        {
            IPAddress = ipAddress;
            Power = power;
            OperatingSystem = os;
        }
    }
}
