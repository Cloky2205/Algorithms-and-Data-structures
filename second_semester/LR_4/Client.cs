using LR_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    internal class Client
    {
        public static void Main(String[] args)
        {
            Random random = new Random();
            int size = 50;
            ChainHashTable table1 = new ChainHashTable(size);
            for (int i = 0; i < size; i++)
            {
                int key = random.Next(1000);
                Link link = new Link(key);
                table1.insert(link);
            }
        }
    }
}
