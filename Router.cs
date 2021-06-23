using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class Router
    {
        public byte[] ip;
        public int index;
        public List<Connection> connections;
        public Router()
        {
            index = 0;
        }
        public Router(byte[] ip, int index)
        {
            this.ip = ip;
            this.index = index;
            connections = new List<Connection>();
        }
        public void AddConnection(int cost, Router r)
        {
            connections.Add(new Connection(cost, r));
        }
        public void RemoveConnection(Router r)
        {
            for(int i = 0; i < connections.Count; i++)
            {
                if(connections[i].target == r)
                {
                    connections.Remove(connections[i]);
                    break;
                }
            }
        }
    }
}
