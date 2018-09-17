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
            a.Push(645);
            a.Push(145);
            a.Push(479);
            a.Print();
            a.Pop();
            a.Push(5);
            a.Push(64);
            a.Pop();
            Console.WriteLine("Last Element = "a.Peek());
            a.Push(7854);
            a.Push(6);
            a.Push(8264);
            a.Push(1234567);
            a.Print();

        }
    }
}
