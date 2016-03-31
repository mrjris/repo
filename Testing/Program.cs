using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing
{

    class node
    {
        public node next;
        public int data;
    }
    class Stack
    {
        node top = null;

        public Stack() { top = null; }
         
        public void push(int x)
        {
            node p = new node();
            p.next = top;
            p.data = x;
            top = p;
        }

        public int pop()
        {
            node p = top;
            int val = top.data;
            top = top.next;
            return val;
        }

        public int peek() { return top.data; }

        public void print(Stack stack)
        {
            node cur = stack.top;
            while (cur != null)
            {
                Console.Write(cur.data + "  ");
                cur = cur.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);
            s.print(s);
            Console.WriteLine();
            s.pop();
            s.pop();
            s.print(s);

            Console.WriteLine("current top = " + s.peek());
            Console.ReadLine();

            
            
        }
    }
}
