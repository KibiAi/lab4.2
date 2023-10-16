using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    interface IConnectable
    {
        void Connect(Computer otherComputer);
        void Disconnect(Computer otherComputer);
        void TransferData(Computer otherComputer, string data);
    }
}
