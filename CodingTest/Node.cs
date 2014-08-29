using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public class Node
    {
        public int n; // value of node
        public Node left; // left subtree
        public Node right; // right subtree
        public Node level; // level pointer (node “to the right”)
    }
   
}
