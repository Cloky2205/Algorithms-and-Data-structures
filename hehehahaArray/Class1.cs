using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class HehehahaArray : HehehahaArrayInterface
{
    private long[] array;
    private int nElems;
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
        for (int i = 0; i < this.nElems; i++)
        {
            if (array[i] < minElem) { minElem = array[i]; }
        }
        return minElem;
    }
    public long findmax()
    {
        long maxElem = array[0];
        for (int i = 0; i < this.nElems; i++)
        {
            if (array[i] > maxElem) { maxElem = array[i]; }
        }
        return maxElem;
    }
    public void insert(long value)
    {
        array[nElems] = value;
        nElems++;
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

