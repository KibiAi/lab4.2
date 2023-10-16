using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Network
    {
        private List<Computer> computers;

        public Network()
        {
            computers = new List<Computer>();
        }

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void SimulateNetwork()
        {
            foreach (Computer computer in computers)
            {
                foreach (Computer otherComputer in computers.Where(c => c != computer))
                {
                    if (computer is IConnectable connectable)
                    {
                        connectable.Connect(otherComputer);
                    }

                    string data = "Це тестові дані";
                    if (computer is IConnectable transferable)
                    {
                        transferable.TransferData(otherComputer, data);
                    }

                    if (computer is IConnectable disconnectable)
                    {
                        disconnectable.Disconnect(otherComputer);
                    }
                }
            }
        }
    }
}
