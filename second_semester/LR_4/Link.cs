using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    public class Link
    {
        private  int key;
        private Link next;

        public Link(int key)
        {
            this.key = key;
        }

        public int getKey()
        {
            return key;
        }

        public Link getNext()
        {
            return next;
        }

        public void setNext(Link next)
        {
            this.next = next;
        }

        public void displayLink()
        {
            Console.WriteLine(key + " ");
        }
    }
}
