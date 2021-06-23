using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class BinaryHeap
    {
        class Node
        {
            public int index;
            public int distance;
            public Node(int index, int distance)
            {
                this.index = index;
                this.distance = distance;
            }
        }
        int[] pointers; //gdzie jest indeks w kopcu
        List<Node> nodes;
        public BinaryHeap(int size)
        {
            nodes = new List<Node>();
            pointers = new int[size];
            nodes.Add(new Node(0, 0)); //placeholder
        }
        public void ChangeNodes(int index, int distance)
        {
            if (pointers[index] != 0) ChangeDistance(index, distance);
            else
            {
                nodes.Add(new Node(index, distance));
                int i = nodes.Count - 1;
                pointers[index] = i;
                Swap(i);
            }
        }
        private void Swap(int i) //do góry
        {
            while (i > 1)
            {
                if (nodes[i / 2].distance > nodes[i].distance)
                {
                    Swap(i / 2, i);
                    i = i / 2;
                }
                else break;
            }
        }
        private void Swap(int from, int to)
        {
            Node temp = nodes[to];
            nodes[to] = nodes[from];
            pointers[nodes[to].index] = to;
            nodes[from] = temp;
            pointers[nodes[from].index] = from;
        }
        public int GetTop()
        {
            return nodes[1].index;
        }
        public void ChangeDistance(int index, int newDistance)
        {
            int i = pointers[index];
            nodes[i].distance = newDistance;
            Swap(i); //zawsze mniejszy dystans
        }
        public void DeleteTop()
        {
            nodes[1].index = nodes[nodes.Count - 1].index;
            nodes[1].distance = nodes[nodes.Count - 1].distance;
            pointers[nodes[1].index] = 1;
            int i = 1;
            nodes.Remove(nodes[nodes.Count - 1]);
            while ((i * 2) < (nodes.Count - 1)) //swap w dół
            {
                if ((i * 2 + 1) < (nodes.Count - 1))
                {
                    if (nodes[i * 2].distance < nodes[i].distance && nodes[i * 2 + 1].distance < nodes[i].distance)
                    {
                        if (nodes[i * 2].distance < nodes[i * 2 + 1].distance)
                        {
                            Swap(i, i * 2);
                            i *= 2;
                        }
                        else
                        {
                            Swap(i * 2 + 1, i);
                            i = i * 2 + 1;
                        }
                    }
                    else if (nodes[i * 2].distance < nodes[i].distance)
                    {
                        Swap(i, i * 2);
                        i *= 2;
                    }
                    else if (nodes[i * 2 + 1].distance < nodes[i].distance)
                    {
                        Swap(i * 2 + 1, i);
                        i = i * 2 + 1;
                    }
                    else break;
                }
                else
                {
                    if (nodes[i * 2].distance < nodes[i].distance)
                    {
                        Swap(i, i * 2);
                        i *= 2;
                    }
                    else break;
                }
            }
        }
        public bool isEmpty()
        {
            if (nodes.Count == 1) return true;
            return false;
        }
    }
}
