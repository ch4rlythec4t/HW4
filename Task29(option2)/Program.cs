using System;
class Program
{
    static int[] CreateArray(int n)
    {
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите  Array[{i}]: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }

    static void WriteArray(int[] array, int arrayLength)
    {
        for (int i = 0; i < arrayLength; i++)
        {
            if (i == arrayLength - 1)
            {
                Console.Write(array[i] + "]");
            }
            else if (i == 0)
            {
                Console.Write("[" + array[i] + ", ");
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
    static void Main()
    {
        Console.Write("Введите N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        WriteArray(CreateArray(N), N);
    }
}