using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektForms
{
    class AVLTree
    {
        private Node root;
        private bool isChangeNeeded;
        private bool IPFound;
        private int computerCount;
        private int index;
        public bool Search(byte[] key)
        {
            IPFound = false;
            Search(root, key);
            return IPFound;
        }
        private void Search(Node current, byte[] key)
        {
            if (current != null)
            {
                if (current.Compare(key) == 0) IPFound = true;
                if (current.Compare(key) < 0) Search(current.right, key);
                if (current.Compare(key) > 0) Search(current.left, key);
            }
        }
        public int SearchRouterIndex(byte[] key)
        {
            index = -1;
            SearchRouterIndex(root, key);
            return index;
        }
        private void SearchRouterIndex(Node current, byte[] key)
        {
            if (current != null)
            {
                if (current.Compare(key, 3) == 0) index = current.index;
                if (current.Compare(key, 3) < 0) SearchRouterIndex(current.right, key);
                if (current.Compare(key, 3) > 0) SearchRouterIndex(current.left, key);
            }
        }
        public void Add(byte[] ipv4)
        {
            isChangeNeeded = false;
            root = Add(root, ipv4, 0);
        }
        public void Add(byte[] ipv4, int index) //dodaj router z indeksem
        {
            isChangeNeeded = false;
            root = Add(root, ipv4, index);
        }
        private Node Add(Node current, byte[] ipv4, int index)
        {
            if (current == null)
            {
                isChangeNeeded = true;
                return new Node(ipv4, index);
            }
            if (current.Compare(ipv4) < 0)
            {
                current.right = Add(current.right, ipv4, index);
                if (isChangeNeeded) current.weight -= 1;

            }
            else if (current.Compare(ipv4) > 0)
            {
                current.left = Add(current.left, ipv4, index);
                if (isChangeNeeded) current.weight += 1;
            }
            if (current.weight == -2 || current.weight == 2) current = Rotate(current);
            if (current.weight == 0) isChangeNeeded = false;
            return current;
        }
        private Node Rotate(Node current)
        {
            if (current.weight == 2 && current.left.weight == 1) return RotateRR(current, false);
            if (current.weight == -2 && current.right.weight == -1) return RotateLL(current, false);
            if (current.weight == 2 && current.left.weight == -1) return RotateLR(current);
            if (current.weight == -2 && current.right.weight == 1) return RotateRL(current);
            if (current.weight == 2 && current.left.weight == 0) return RotateRR(current, true);
            if (current.weight == -2 && current.right.weight == 0) return RotateLL(current, true);
            return null;
        }
        private Node RotateRR(Node current, bool weightFix)
        {
            Node temp = current;
            Node tempLeft = current.left;
            temp.left = tempLeft.right;
            tempLeft.right = temp;
            if (weightFix)
            {
                tempLeft.weight = -1;
                tempLeft.right.weight = 1;
            }
            else
            {
                tempLeft.weight = 0;
                temp.weight = 0;
            }
            return tempLeft;
        }
        private Node RotateLL(Node current, bool weightFix)
        {
            Node temp = current;
            Node tempRight = current.right;
            temp.right = tempRight.left;
            tempRight.left = temp;
            if (weightFix)
            {
                tempRight.weight = 1;
                tempRight.left.weight = -1;
            }
            else
            {
                tempRight.weight = 0;
                temp.weight = 0;
            }
            return tempRight;
        }
        private Node RotateRL(Node current)
        {
            int weight = current.right.left.weight;
            Node temp = current;
            Node tempRight = RotateRR(temp.right, false);
            temp.right = tempRight.left;
            tempRight.left = temp;
            tempRight.weight = 0;
            switch (weight)
            {
                case -1:
                    tempRight.left.weight = 1;
                    tempRight.right.weight = 0;
                    break;
                case 0:
                    tempRight.left.weight = 0;
                    tempRight.right.weight = 0;
                    break;
                case 1:
                    tempRight.left.weight = 0;
                    tempRight.right.weight = -1;
                    break;
            }
            return tempRight;
        }
        private Node RotateLR(Node current)
        {
            int weight = current.left.right.weight;
            Node temp = current;
            Node tempLeft = RotateLL(temp.left, false);
            temp.left = tempLeft.right;
            tempLeft.right = temp;
            tempLeft.weight = 0;
            switch (weight)
            {
                case -1:
                    tempLeft.left.weight = 1;
                    tempLeft.right.weight = 0;
                    break;
                case 0:
                    tempLeft.left.weight = 0;
                    tempLeft.right.weight = 0;
                    break;
                case 1:
                    tempLeft.left.weight = 0;
                    tempLeft.right.weight = -1;
                    break;
            }
            return tempLeft;
        }
        public void Delete(byte[] key)
        {
            isChangeNeeded = false;
            root = Delete(root, key);
        }
        private Node Delete(Node current, byte[] key)
        {
            if (current != null)
            {
                if (current.Compare(key) > 0)
                {
                    current.left = Delete(current.left, key);
                    if (isChangeNeeded) current.weight -= 1;
                }
                else if (current.Compare(key) < 0)
                {
                    current.right = Delete(current.right, key);
                    if (isChangeNeeded) current.weight += 1;
                }
                else if (current.Compare(key) == 0)
                {
                    isChangeNeeded = true;
                    if (current.right == null && current.left == null) return null;
                    else if (current.right != null && current.left == null) return current.right;
                    else if (current.right == null && current.left != null) return current.left;
                    else
                    {
                        Node temp = GetReplacement(current.right);
                        temp.weight = current.weight;
                        temp.left = current.left;
                        temp.right = Delete(current.right, temp.data);
                        if (isChangeNeeded) temp.weight += 1;
                        current = temp;
                    }
                }
                if (current.weight == -2 || current.weight == 2) current = Rotate(current);
                if (current.weight == 1 || current.weight == -1) isChangeNeeded = false;
                return current;
            }
            return null;
        }
        private Node GetReplacement(Node current)
        {
            while (current.left != null)
            {
                current = current.left;
            }
            return new Node(current.data);
        }
        public int Count(byte[] key)
        {
            computerCount = 0;
            Count(root, key);
            return computerCount;
        }
        private void Count(Node current, byte[] key)
        {
            if (current != null)
            {
                if (current.Compare(key, 3) > 0) Count(current.left, key);
                if (current.Compare(key, 3) < 0) Count(current.right, key);
                if (current.Compare(key, 3) == 0)
                {
                    computerCount++;
                    Count(current.left, key);
                    Count(current.right, key);
                }
            }
        }
        public Node GetRoot()
        {
            return root;
        }
        public void Clear()
        {
            root = null;
        }
        public void Print()
        {
            int p = 0;
            Print(root, p);
        }
        public void Print(Node n, int p)
        {
            if (n != null)
            {
                Print(n.right, p + 10);
                for (int i = 0; i < p; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(n);
                Print(n.left, p + 10);
            }
        }
    }
}
