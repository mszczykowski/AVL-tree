using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class Connection
    {
        public int cost;
        public Router target;
        public Connection(int cost, Router target)
        {
            this.cost = cost;
            this.target = target;
        }
    }
}
