using System;


public class HehehahaArrayClient
{
    public static void Main(String[] args)
    {
        Random random = new Random();
        int size = 100;
        HehehahaArrayInterface array = new HehehahaArray(size);

        for (int i = 0; i < size; i++)
        { 
            array.insert(random.NextInt64(1000));
        }
        array.sort();
        array.display();

        long searchValue = random.NextInt64(1000);
        long value = random.NextInt64(1000);
        if (array.find(searchValue))
        {
            Console.WriteLine("Значение было найдено. " + searchValue);
        }
        else
        {
            Console.WriteLine("Не удалось найти значение. " + searchValue);
        }
        if (array.contains(searchValue)) { Console.WriteLine("Значение было найдено. " + searchValue); }
        else { Console.WriteLine("Не удалось найти значение. " + searchValue); }
       
        Console.WriteLine("Минимальное значение: " + array.findmin());
        Console.WriteLine("Максимальное значение: " + array.findmax());

        if (array.delete(value)) { Console.WriteLine("Значение " + value + " было удалено"); }
        else { Console.WriteLine("Значения " + value + " нет в массиве"); }


        Console.ReadLine();
    }


}
