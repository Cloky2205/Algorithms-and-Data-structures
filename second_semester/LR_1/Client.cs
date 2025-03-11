using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    public class ClassArrayClient
    {
        public static void Main(String[] args)
        {
            Random random = new Random();
            int size = 1000000;
           ClassArrayInterface array = new Class_Array(size);

            for (int i = 0; i < size; i++)
            {
                array.insert(random.NextInt64(1000000));
            }
            array.sortShella();
            array.sortKnutha(); 
            //array.display();

           
            Console.ReadLine();
        }


    }
}
