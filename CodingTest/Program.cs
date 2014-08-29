using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node() { n = 1 };
            Node child1Node = new Node() { n = 2 };
            Node child2Node = new Node() { n = 3 };
            Node child11Node = new Node() { n = 4 };
            Node child21Node = new Node() { n = 5 };
            Node child22Node = new Node() { n = 6 };
            root.left = child1Node;
            root.right = child2Node;
            child1Node.left = child11Node;
            child2Node.left = child21Node;
            child2Node.right = child22Node;
            linkSameLevel(root);
            Console.ReadKey();
        }

        public static void linkSameLevel(Node t)
        {
            if (t == null)
            {
                return;
            }
            if (t.level!=null)
            {
                linkSameLevel(t.level);
            }

            if (t.left!=null)
            {
                if (t.right!=null)
                {
                    t.left.level = t.right;
                    t.right.level = GetNextLevel(t);
                }
                else
                {
                    t.left.level = GetNextLevel(t);
                    linkSameLevel(t.left);
                }

            }
            else if(t.right!=null)
            {
                t.right.level = GetNextLevel(t);
                linkSameLevel(t.right);
            }
            else
            {
                linkSameLevel(GetNextLevel(t));
            }
        }

        private static Node GetNextLevel(Node node)
        {
            Node temp = node.level;

            while (temp!=null)
            {
                if (temp.left!=null)
                {
                    return temp.left;
                }
                if (temp.right!=null)
                {
                    return temp.right;
                }
                temp = temp.level;
            }
            return null;
        }
    }
}
