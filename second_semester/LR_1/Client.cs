using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    public class HehehahaArrayClient
    {
        public static void Main(String[] args)
        {
            Random random = new Random();
            int size = 1000000;
            HehehahaArrayInterface array = new HehehahaArray(size);

            for (int i = 0; i < size; i++)
            {
                array.insert(random.NextInt64(1000000));
            }
            array.sortKnutha();
            array.sortShella(); 
            //array.display();

           
            Console.ReadLine();
        }


    }
}
