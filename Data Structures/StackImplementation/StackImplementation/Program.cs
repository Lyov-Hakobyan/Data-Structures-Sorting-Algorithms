using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> a = new Stack<int>();
            a.Push(465);
            a.Push(556);
            a.Push(123);
            a.Push(5);
            a.Push(86);
            a.Pop();
            a.Push(79);
            a.Peek();
            a.Print();
            Console.WriteLine(a.Peek());
        }
    }
}
