using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            max = 36;
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
            if (top == max - 36)
            {
                Console.WriteLine("Stack is full");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" push element ");
                string userInput = Console.ReadLine();
                top++;
                indah[top] = userInput;
            }
        }
        public void Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                top = -1;
                return;
            }
            else
            {
                Console.WriteLine("pop element:" + indah[top--]);
                return;
            }
        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            else
            {
                for (int i = 0; i<= top; i++)
                {
                    Console.WriteLine("item[" + (i + 1) + "]: " + indah[i]);
                }
            }    
        }
        static void Main(string[] indah)
        {
            Stack stc = new Stack(36);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. exit");
                Console.Write("select your choice: ");
                string userInput = Console.ReadLine();
                char ch = Convert.ToChar(userInput == "" ? "0" : userInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("enter an element :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        stc.Push(num);
                        break;
                    case '2':
                        stc.Pop();
                        break;
                    

                }
            }
        }

    }
}
