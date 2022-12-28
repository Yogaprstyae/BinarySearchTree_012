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
            public void Insert (string element) /* Insert a node in the binary search tree */
            {
                Node tmp, parent = null, currentNode = null;
                Search(element, ref parent, ref currentNode);
                if (currentNode != null) /*Check id the node to be inserted already inserted or not */
                {
                    Console.WriteLine("Duplicate words not allowed");
                    return;
                }
                else /* If the specified node is not present */
                {
                    tmp = new Node(element, null, null); /* Creates a Node */
                    if (parent == null) /* If thetrees is empty */
                    {
                        ROOT = tmp;
                    }
                    else if (string.Compare(element,parent.info) < 0)
                    {
                        parent.leftchild = tmp;
                    }
                    else
                    {
                        parent.rightchild = tmp;
                    }
                }
            }
            public void InOrder(Node ptr)
            {
                if (ROOT == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                if (ptr != null)
                {
                    InOrder(ptr.leftchild);
                    Console.Write(ptr.info + " ");
                    InOrder(ptr.rightchild);
                }
            }
            public void PreOrder(Node ptr)
            {
                if (ROOT == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                if (ptr != null)
                {
                    Console.Write(ptr.info + " ");
                    PreOrder(ptr.leftchild);
                    PreOrder(ptr.rightchild);
                }
            }
            public void PostOrder(Node ptr) /* Preform the postorder traversal of the three */
            {
                if (ROOT == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                if (ptr != null)
                {
                    PostOrder(ptr.leftchild);
                    PostOrder(ptr.rightchild);
                    Console.Write(ptr.info + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Program x = new Program();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implementasi insert option");
                Console.WriteLine("2. Perform InOrder traversal");
                Console.WriteLine("3. Perform PreOrder traversal");
                Console.WriteLine("4. Perform PostOrder traversal");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter your choise (1-5) :");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");
                            string word = Console.ReadLine();
                            x.Insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.InOrder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.PreOrder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.PostOrder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }
            }
        }
    }
}
