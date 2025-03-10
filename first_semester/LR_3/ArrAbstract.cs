using System;


public abstract class ArrAbstract : ArrInterface
{
    protected long[] array;
    protected int nElems;

    public abstract bool find( long n);
    public abstract bool delete(long n);
    public virtual long findmin()
    {
        long minElem = array[0];
        for (int i = 0; i < this.nElems; i++)
        {
            if (array[i] < minElem) { minElem = array[i]; }
        }
        return minElem;
    }
    public virtual long findmax()
    {
        long maxElem = array[0];
        for (int i = 0; i < this.nElems; i++)
        {
            if (array[i] > maxElem) { maxElem = array[i]; }
        }
        return maxElem;
    }

    public abstract bool insert(long value);

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
