using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Stack
{
    public class StackImpl
    {

        private int maxSize;
        private char[] stackArray;
        private int top;

        public StackImpl(int s)
        {
            maxSize = s;
            stackArray = new char[maxSize];
            top = -1;
        }

        public void push(char j)
        {
            try
            {
                if (top == maxSize - 1)
                {
                    throw new Exception("Стэк полный");
                }
                else {  stackArray[++top] = j;}
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }

        public char pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("Стэк пустой");
                }
                else { return stackArray[top--]; }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return '\0';
            }
        }

        public char peek()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("Стэк пустой");
                }
                else { return stackArray[top]; }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return '\0';
            }
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == maxSize - 1);
        }
       
    }

}
