using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public class HehehahaArrayClient
    {
        public static void Main(String[] args)
        {
            Random random1 = new Random();
            int size = 1000000;
            ClassArrayInterface array1 = new Class_Array(size);

            for (int i = 0; i < size; i++)
            {
                array1.insert(random1.NextInt64(1000000));
            }
            array1.qsort();

            Random random2 = new Random();
            int size2 = 1000000;
            ClassArrayInterface array2 = new Class_Array(size);

            for (int i = 0; i < size; i++)
            {
                array2.insert(random2.NextInt64(1000000));
            }
            array2.msort();

            Random random3 = new Random();
            int size3 = 1000000;
            ClassArrayInterface array3 = new Class_Array(size);

            for (int i = 0; i < size; i++)
            {
                array3.insert(random2.NextInt64(1000000));
            }
            array3.shsort();


            Console.ReadLine();
        }


    }
}
