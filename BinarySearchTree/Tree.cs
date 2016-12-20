using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }
        public Tree(int initial)
        {
            top = new Node(initial);
        }
        public void Add(int value)
        {
            if (top == null)
            {
                Node newNode = new Node(value);
                top = newNode;
                return;
            }
            Node currentNode = top;
            bool check = false;
            do
            {
               if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        check = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
               if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        check = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            } while (!check);
        }
        public void AddRec(int value)
        {
            AddRecLogic(ref top, value);
        }
        public void AddRecLogic(ref Node node, int value)
        {
            if (node == null)
            {
                Node newNode = new Node(value);
                node = newNode;
                return;
            }
            if (value < node.value)
            {
                AddRecLogic(ref node.left, value);
                return;
            }
            if (value >= node.value)
            {
                AddRecLogic(ref node.right, value);
                return;
            }
        }

    }
}
