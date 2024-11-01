using System;
using System.Buffers;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        this.nElems = 0;
    }

    public bool sort()
    {
        isSorted = true;
        Array.Sort(this.array);

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
        else {
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

