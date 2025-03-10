using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    public class HehehahaArray : HehehahaArrayInterface
    {
        private long[] array;
        private int nElems;
        public bool isSorted = false;
        public HehehahaArray(int size)
        {

            this.array = new long[size];
            this.nElems = 0;
        }
        public HehehahaArray()
        {

            this.array = new long[0];
            this.nElems = 0;
        }
        public HehehahaArray(long[] elems)
        {
            this.array = elems;
            this.nElems = elems.Length;
        }

        public bool sortShella()
        {
            isSorted = true;
            int inner, outer;
            long temp;
            int h = nElems/2;
            var sw = new Stopwatch();
            sw.Start();
            
            while (h <= nElems / 3)
            {
                h = h * 3 + 1;
            }

            
            while (h > 0)
            {
                for (outer = h; outer < nElems; outer++)
                {
                    temp = array[outer]; 
                    inner = outer;
                    while (inner > h - 1 && array[inner - h] >= temp)
                    { 
                        array[inner] = array[inner - h];
                        inner -= h;
                    }
                    array[inner] = temp;
                }
                h = (h - 1) / 3; 
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());
            return isSorted;
        }
        public bool sortKnutha()
        {
            isSorted = true;
            int inner, outer;
            long temp;
            int h = nElems / 2;
            var sw = new Stopwatch();
            sw.Start();

           


            while (h > 0)
            {
                for (outer = h; outer < nElems; outer++)
                {
                    temp = array[outer];
                    inner = outer;
                    while (inner > h - 1 && array[inner - h] >= temp)
                    {
                        array[inner] = array[inner - h];
                        inner -= h;
                    }
                    array[inner] = temp;
                }
                h /= 2;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());
            return isSorted;
        }
        public bool find(long searchValue)
        {
            for (int i = 0; i < this.nElems; i++)
            {
                if (array[i] == searchValue)
                {
                    return true;
                }
            }

            return false;
        }
        public long findmin()
        {
            long minElem = array[0];
            if (isSorted) { return minElem; }
            else
            {
                for (int i = 0; i < this.nElems; i++)
                {
                    if (array[i] < minElem) { minElem = array[i]; }
                }
                return minElem;
            }

        }
        public long findmax()
        {
            long maxElem = array[0];
            if (isSorted) { maxElem = array[nElems - 1]; return maxElem; }
            else
            {
                for (int i = 0; i < this.nElems; i++)
                {
                    if (array[i] > maxElem) { maxElem = array[i]; }
                }
                return maxElem;
            }

        }
        public void insert(long value)
        {
            array[nElems] = value;
            nElems++;
        }
        public bool contains(long searchValue)
        {
            int operationsNumber = 0;
            int lowerBound = 0;
            int upperBound = nElems - 1;
            int currentIndex;

            while (true)
            {
                Console.WriteLine("Количество операций в упорядоченном массиве: " + ++operationsNumber);
                currentIndex = (lowerBound + upperBound) / 2;
                long currentElement = array[currentIndex];
                if (currentElement == searchValue)
                {
                    return true;
                }
                else if (lowerBound > upperBound)
                {
                    return false;
                }
                else
                {
                    if (currentElement < searchValue)
                    {
                        lowerBound = currentIndex + 1;
                    }
                    else
                    {
                        upperBound = currentIndex - 1;
                    }
                }
            }
        }

        public bool delete(long value)
        {
            int operationsNumber = 0;
            int lowerBound = 0;
            int upperBound = nElems - 1;
            int currentIndex;

            while (true)
            {
                Console.WriteLine("Количество операций в упорядоченном массиве: " + ++operationsNumber);
                currentIndex = (lowerBound + upperBound) / 2;
                long currentElement = array[currentIndex];
                if (currentElement == value)
                {
                    for (int j = currentIndex; j < nElems - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    nElems--;
                    return true;

                }
                else if (lowerBound > upperBound)
                {
                    Console.WriteLine("Числа нет в массиве");
                    return false;
                }
                else
                {
                    if (currentElement < value)
                    {
                        lowerBound = currentIndex + 1;
                    }
                    else
                    {
                        upperBound = currentIndex - 1;
                    }
                }
            }
        }



        public void display()
        {
            for (int i = 0; i < nElems; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
        }

        public int getSize()
        {
            return this.nElems;
        }
    }
}
