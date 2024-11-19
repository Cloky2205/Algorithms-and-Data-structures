using LR4;

Random random = new Random();
int size = 10000;
HighInterfaceArrayImpl array1 = new HighInterfaceArrayImpl(size);

for (int i = 0; i < size; i++)
{ 
    array1.insert(random.NextInt64(100000));
}

array1.bubbleSort();



HighInterfaceArrayImpl array2 = new HighInterfaceArrayImpl(size);

for (int i = 0; i < size; i++)
{
    array2.insert(random.NextInt64(100000));
}
array2.insertionSort();





HighInterfaceArrayImpl array3 = new HighInterfaceArrayImpl(size);

for (int i = 0; i < size; i++)
{
    array3.insert(random.NextInt64(100000));
}
array3.selectionSort();

Console.ReadLine(); 
