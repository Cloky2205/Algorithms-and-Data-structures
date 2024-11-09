using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class BedaArraySorted : ArrAbstract
{

	public BedaArraySorted(int size)
	{
       array = new long[size];
       nElems = 0;
    }
    public BedaArraySorted(long[] elems)
    {
        this.array = elems;
        this.nElems = elems.Length;
    }
    public override bool insert(long value)
    {
        if (this.find(value))
        {
            return false;
        }

        int i;
        for (i = 0; i < nElems; i++)
        {
            if (array[i] > value)
            {
                break;
            }
        }

        for (int j = nElems; j > i; j--)
        {
            array[j] = array[j - 1];
        }

        array[i] = value;
        nElems++;
        return true;
    }
    public override bool delete(long value)
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
    public override long findmax()
    {
        long maxElem = array[nElems-1];
        return maxElem;
    }

    public override long findmin()
    {
        long minElem = array[0];
        return minElem;
    }
    public override bool find(long searchValue)
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

}
