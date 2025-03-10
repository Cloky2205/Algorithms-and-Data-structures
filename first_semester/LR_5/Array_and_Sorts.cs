using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class HighInterfaceArrayImpl
    {
        private long[] array;
        private int nElems;

        public HighInterfaceArrayImpl(int size)
        {
            this.array = new long[size];
            this.nElems = 0;
        }

        private void swap(int one, int two)
        {
            long temp = array[one];
            array[one] = array[two];
            array[two] = temp;
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


        public void insert(long value)
        {
            array[nElems] = value;
            nElems++;
        }

        public bool delete(long value)
        {
            int i;
            for (i = 0; i < this.nElems; i++)
            {
                if (array[i] == value)
                {
                    break;
                }
            }

            if (i == nElems - 1)
            {
                return false;
            }
            else
            {
                for (int j = i; j < nElems - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                nElems--;
                return true;
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
        public void bubbleSort()
        {
            var sw = new Stopwatch();
            sw.Start();
            
            for (int outl = nElems - 1; outl > 1; outl--) { 
                for (int inl = 0; inl < outl; inl++) {  
                    if (array[inl] > array[inl +1])
                    { 
                        swap(inl, inl +1); 
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Сортировка выбором" + " " + sw.Elapsed);
        }
        public void insertionSort()
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int outl = 1; outl < nElems; outl++) { 
                long temp = array[outl]; 
                int inl = outl; 
                while (inl > 0 && array[inl -1] >= temp) { 
                    array[inl] = array[inl -1]; 
                    --inl; 
                }
                array[inl] = temp; 
            }
            sw.Stop();
            Console.WriteLine("Сортировка вставкой" + " " + sw.Elapsed);
        }
        public void selectionSort()
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int outl = 0; outl < nElems - 1; outl++) { 
                int min = outl; 
                for (int inl = outl +1; inl < nElems; inl++) { 
                    if (array[inl] < array[min])
                    { 
                        min = inl; 
                    }
                }
                swap(outl, min); 
            }
            sw.Stop();
            Console.WriteLine("Сортировка выбором" + " " + sw.Elapsed);
        }
    }
}