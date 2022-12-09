using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class Stack
    {
        private string[] indah;
        int element;
        int max;
        int top;
        public Stack(int size)
        {
            top = -1;
            max = size;
            indah = new string[size];
        }
        public bool isEmpty()
        {
            if (top == null)
                return true;
            return false;
        }
        public void Push(int element)
        {
            if (top == max -1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                indah[top++] = 
            }
        }
    }
}
