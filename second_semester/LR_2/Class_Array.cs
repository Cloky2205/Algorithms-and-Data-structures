using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    public class Class_Array : ClassArrayInterface
    {
        private long[] array;
        private int nElems;
        public bool isSorted = false;
        public int quickswapCount = 0;
        public int quickifCount = 0;
        public int mergeswapCount = 0;
        public int mergeifCount = 0;
        public int shellswapCount = 0;
        public int shellifCount = 0;
        public Class_Array(int size)
        {

            this.array = new long[size];
            this.nElems = 0;
        }
        public Class_Array()
        {

            this.array = new long[0];
            this.nElems = 0;
        }
        public Class_Array(long[] elems)
        {
            this.array = elems;
            this.nElems = elems.Length;
        }
        public void shsort()
        {
            var sw = new Stopwatch();
            sw.Start();
            int inner, outer;
            long temp;
            int h = 1;

            
            while (h <= nElems / 3)
            {
                shellifCount++;
                h = h * 3 + 1;
            }

            
            while (h > 0)
            {
                shellifCount++;
                for (outer = h; outer < nElems; outer++)
                {
                    temp = array[outer]; 
                    inner = outer;
                    while (inner > h - 1 && array[inner - h] >= temp)
                    {
                        shellifCount++;
                        
                        array[inner] = array[inner - h];
                        shellswapCount++;
                        inner -= h;
                    }
                    array[inner] = temp;
                    shellswapCount++;
                }
                h = (h - 1) / 3; 
            }
            sw.Stop();
            Console.WriteLine("Cортировка Шелла отработала за " + sw.Elapsed.ToString() + " , проверок проведено " + shellifCount + " , перестановок проведено " + shellswapCount);
        }
        public void msort()
        {
            var sw = new Stopwatch();
            sw.Start();
            long[] tempArray = new long[nElems];
            mergeSort(tempArray, 0, nElems - 1);
            sw.Stop();
            Console.WriteLine("Cортировка слиянием отработала за " + sw.Elapsed.ToString() + " , проверок проведено " + mergeifCount + " , перестановок проведено " + mergeswapCount);
        }

        private void mergeSort(long[] tempArray, int lowerBound, int upperBound)
        {
            if (lowerBound != upperBound)
            { 
                int middle = (lowerBound + upperBound) / 2; 
                mergeSort(tempArray, lowerBound, middle); 
                mergeSort(tempArray, middle + 1, upperBound); 
                merge(tempArray, lowerBound, middle + 1, upperBound); 
            }
        }

        private void merge(long[] tempArr, int lowPtr, int highPtr, int upperBound)
        {
            mergeswapCount++;   
            int tempArrIndex = 0;
            int lowerBound = lowPtr;
            int middle = highPtr - 1;
            int elementsNumber = upperBound - lowerBound + 1;

            while (lowPtr <= middle && highPtr <= upperBound)
            {
                
                if (array[lowPtr] < array[highPtr])
                {
                    mergeifCount++;
                    tempArr[tempArrIndex++] = array[lowPtr++];
                }
                else
                {
                    mergeifCount++;
                    tempArr[tempArrIndex++] = array[highPtr++];
                }
            }

            while (lowPtr <= middle)
            {
                mergeifCount++;
                tempArr[tempArrIndex++] = array[lowPtr++];
            }

            while (highPtr <= upperBound)
            {
                mergeifCount++;
                tempArr[tempArrIndex++] = array[highPtr++];
            }

            for (tempArrIndex = 0; tempArrIndex < elementsNumber; tempArrIndex++)
            {
                array[lowerBound + tempArrIndex] = tempArr[tempArrIndex];
                mergeswapCount++;
            }
        }
        public void qsort()
        {
            var sw = new Stopwatch();
            sw.Start();
            quickSort(0, nElems - 1);
            sw.Stop();
            Console.WriteLine("Быстрая сортировка отработала за " + sw.Elapsed.ToString()+ " , проверок проведено " + quickifCount + " , перестановок проведено " + quickswapCount);
        }

        public void quickSort(int leftIndex, int rightIndex)
        {
            if (rightIndex - leftIndex + 1 <= 3)
            {
                quickifCount++;
                insertionSort(leftIndex, rightIndex);
            }
            else
            {
                quickifCount++;
                long pivot = medianOfThreePoints(leftIndex, rightIndex);

                int partition1 = partition(leftIndex, rightIndex, pivot);
                quickSort(leftIndex, partition1 - 1);
                quickSort(partition1 + 1, rightIndex);
            }
        }
        public long medianOfThreePoints(int leftIndex, int rightIndex)
        {
            int center = (leftIndex + rightIndex) / 2;

            if (array[leftIndex] > array[center])
            {
                quickifCount++;
                swap(leftIndex, center);

            }
            else if (array[leftIndex] > array[rightIndex])
            {
                quickifCount++;
                swap(leftIndex, rightIndex);

            }
            else if (array[center] > array[rightIndex])
            {
                quickifCount++;
                swap(center, rightIndex);

            }
            swap(center, rightIndex - 1);

            return array[rightIndex - 1];
        }

        public int partition(int leftIndex, int rightIndex, long pivot)
        {
            int leftPtr = leftIndex - 1;
            int rightPtr = rightIndex;
            while (true)
            {
                do
                {
                    leftPtr += 1;
                } while (array[leftPtr] < pivot);

                do
                {
                    rightPtr -= 1;
                }
                while (rightPtr > leftIndex && array[rightPtr] > pivot);

                if (leftPtr >= rightPtr)
                {
                    quickifCount++;
                    break;
                }
                else
                {
                    quickifCount++;
                    swap(leftPtr, rightPtr);

                }
            }
            swap(leftPtr, rightIndex);

            return leftPtr;
        }
        public void swap(int index1, int index2)
        {
            
            long temp = array[index1];
            quickswapCount++;
            array[index1] = array[index2];
            quickswapCount++;
            array[index2] = temp;
            quickswapCount++;
        }

        public void insertionSort(int leftIndex, int rightIndex)
        {
            for (int outl = leftIndex + 1; outl < rightIndex; outl++)
            {
                long temp = array[outl];
                int inl = outl;
                while (inl > 0 && array[inl - 1] >= temp)
                {
                    array[inl] = array[inl - 1];
                    --inl;
                }
                array[inl] = temp;

            }
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
