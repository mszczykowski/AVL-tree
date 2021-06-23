using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class Graph
    {
        private List<Router> routers;
        private const int inf = 999999999;
        private int index;
        private AVLTree tree;
        private AVLTree routerTree;
        private int[,] distances;
        public Graph(AVLTree tree)
        {
            routers = new List<Router>();
            routers.Add(new Router()); //placeholder
            index = 1; //używam tablic od 1
            this.tree = tree;
            this.routerTree = new AVLTree(); //drzewo podsieci
        }
        public void AddRouter(byte[] ip)
        {
            byte[] ipR = new byte[4];
            Array.Copy(ip, ipR, 3);
            if (!routerTree.Search(ipR))
            {
                routerTree.Add(ipR, index);
                routers.Add(new Router(ipR, index));
                index++;
            }
        }
        public void AddConnection(byte[] ip1, byte[] ip2, int cost)
        {
            int index1 = routerTree.SearchRouterIndex(ip1);
            int index2 = routerTree.SearchRouterIndex(ip2);
            if (index1 != -1 && index2 != -1)
            {
                routers[index1].AddConnection(cost, routers[index2]);
                routers[index2].AddConnection(cost, routers[index1]);
            }
        }
        public void RemoveConnection(byte[] ip1, byte[] ip2)
        {
            int index1 = routerTree.SearchRouterIndex(ip1);
            int index2 = routerTree.SearchRouterIndex(ip2);
            if (index1 != -1 && index2 != -1)
            {
                routers[index1].RemoveConnection(routers[index2]);
                routers[index2].RemoveConnection(routers[index1]);
            }
        }
        public int FastestConnection(byte[] ip1, byte[] ip2)
        {
            int startIndex = routerTree.SearchRouterIndex(ip1);
            int targetIndex = routerTree.SearchRouterIndex(ip2);
            if (!tree.Search(ip1) || !tree.Search(ip2)) return 0;

            int[] distance = new int[index];
            int[] previous = new int[index];
            BinaryHeap heap = new BinaryHeap(index);

            int s = startIndex;
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = inf;
                previous[i] = 0;
            }
            distance[s] = 0;

            heap.ChangeNodes(s, 0);
            do
            {
                s = heap.GetTop();
                heap.DeleteTop();
                foreach (Connection c in routers[s].connections)
                {
                    if (distance[s] + c.cost < distance[c.target.index])
                    {
                        distance[c.target.index] = distance[s] + c.cost;
                        heap.ChangeNodes(c.target.index, distance[s] + c.cost);
                        previous[c.target.index] = s;
                    }
                }
            }
            while (!heap.isEmpty());
            if (distance[targetIndex] == inf) return 0;
            return distance[targetIndex];
        }
        public int FastestConnection2(byte[] ip1, byte[] ip2, int k)
        {
            int startIndex = routerTree.SearchRouterIndex(ip1);
            int targetIndex = routerTree.SearchRouterIndex(ip2);
            if (!tree.Search(ip1) || !tree.Search(ip2)) return 0;
            DjikstraModified(startIndex, k);
            if (distances[targetIndex, k] == inf) return 0;
            return distances[targetIndex, k];
        }
        public void DjikstraModified(int startIndex, int k)
        {
            k = k + 1;
            int[] previous = new int[index];
            BinaryHeap heap = new BinaryHeap(index);
            distances = new int[index, k];
            int s = startIndex;
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    distances[i, j] = inf;
                }
                previous[i] = 0;
            }
            for (int j = 0; j < k; j++)
            {
                distances[s, j] = 0;
            }

            heap.ChangeNodes(s, 0);
            do
            {
                s = heap.GetTop();
                heap.DeleteTop();
                foreach (Connection c in routers[s].connections)
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (i == 0)
                        {
                            if (distances[s, i] + c.cost < distances[c.target.index, i])
                            {
                                distances[c.target.index, i] = distances[s, i] + c.cost;
                                heap.ChangeNodes(c.target.index, distances[s, i] + c.cost);
                                previous[c.target.index] = s;
                            }
                        }
                        else
                        {
                            if (distances[s, i - 1] + 1 < distances[c.target.index, i])
                            {
                                distances[c.target.index, i] = distances[s, i - 1] + 1;
                            }
                            if (distances[s, i] + c.cost < distances[c.target.index, i])
                            {
                                distances[c.target.index, i] = distances[s, i] + c.cost;
                            }

                        }
                    }
                }
            }
            while (!heap.isEmpty());
        }
        public void Print(int k)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("k" + i + " ");
                for (int j = 0; j < index; j++)
                {
                    if (distances[j, i] == inf) Console.Write("x ");
                    else Console.Write(distances[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
