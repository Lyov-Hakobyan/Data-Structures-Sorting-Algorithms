using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList t = new LinkedList();
            t.AddToFront(1);
            t.AddToFront(2);
            t.AddToLast(3);
            t.AddToAfter(2, 8);
            t.DeleteNode(8);
            t.PrintAllNodes();
        }
    }
}