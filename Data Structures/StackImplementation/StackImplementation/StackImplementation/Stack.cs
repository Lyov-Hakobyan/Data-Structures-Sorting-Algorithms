using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackImplementation
{
    class Stack<T>
    {
        private LinkedList<T> stack = new LinkedList<T>();
        public void Push(T t)
        {
            stack.AddLast(t);
        }
        public T Pop()
        {
            T result = stack.Last();
            stack.RemoveLast();
            return result;
        }
        public T Peek()
        {
            return stack.Last();
        }
        public bool IsEmpty()
        {
            return stack.Any();
        }
        public void Print()
        {
            foreach (var k in stack)
            {
                Console.WriteLine(k + ", ");
            }
            Console.WriteLine();
        }
    }
}
