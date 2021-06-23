using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class Node
    {
        public byte[] data;
        public int weight;
        public Node left;
        public Node right;
        public int index;
        public Node(byte[] data)
        {
            this.data = data;
            weight = 0;
        }
        public Node(byte[] data, int index)
        {
            this.data = data;
            this.index = index;
            weight = 0;
        }
        public int Compare(byte[] ipv4)
        {
            return Compare(ipv4, data.Length);
        }
        public int Compare(byte[] ipv4, int blocks)
        {
            for (int i = 0; i < blocks; i++)
            {
                if (data[i] < ipv4[i]) return -1;
                if (data[i] > ipv4[i]) return 1;
            }
            return 0;
        }
        public override String ToString()
        {
            return "" + data[0] + "." + data[1] + "\n" + data[2] + "." + data[3] + "\nw: " + weight;
        }
    }
}
