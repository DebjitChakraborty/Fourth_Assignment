using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = CheckStack();
                foreach (var stackItem in stack)
                {
                    Console.WriteLine(stackItem);
                }
            }
            catch (StackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }

        static Stack CheckStack()
        {
            Console.WriteLine("The size of the stack is 5");
            Stack stack1 = new Stack(5);
            stack1.Push(15);
            stack1.Push(28);
            stack1.Push(78);
            stack1.Push(24);
            stack1.Push(54);
            stack1.Push(86);
            //stack1.Pop();
            Console.WriteLine("No of elements in stack is " + stack1.Count);
            if (stack1.Count > 5)
            {
                throw new StackException("Stack Overflow.");
            }
            else if (stack1.Count == 0)
            {
                throw new StackException("Stack Underflow.");
            }
            return stack1;
        }

    }
}
