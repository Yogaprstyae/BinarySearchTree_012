using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_012
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        // Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
        /* A node class concists of three thins, he information,
          references to the right vhild, nad references to the left child */
        class Program
        {
            public Node ROOT;
            public Program()
            {
                ROOT = null; /* Initializing root to null*/
            }
            public void Search (string element, ref Node parent, ref Node currentNode)
            {
                /* This function searchs the currentNode of the specified Node as well
                 * ass the current Node of its parents */
                currentNode = ROOT;
                parent = null;
                while ((currentNode != null) && (currentNode.info != element))
                {
                    parent = currentNode;
                    if (string.Compare(element, currentNode.info) < 0)
                        currentNode = currentNode.leftchild;
                    else
                        currentNode = currentNode.rightchild;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
