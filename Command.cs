using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class Command
    {
        public string operation;
        public byte[] ip1;
        public byte[] ip2;
        public int cost;
        public int k;
        public Command(string operation)
        {
            this.operation = operation;
        }
        public Command(string operation, byte[] ip1)
        {
            this.operation = operation;
            this.ip1 = ip1;
        }
    }
}
