using System;
class Program
{
    static double Sum(int num)
    {
        int numLength = Convert.ToInt32(Math.Truncate(Math.Log10(num) + 1));

        double[] array = new double[numLength];
        double temp = 0;
        double result = 0;

        for (int i = 1; i < numLength + 1; i++)
        {
            array[i - 1] = Math.Truncate((num - temp) / Math.Pow(10, (numLength - (i))));
            temp = temp + array[i - 1] * Math.Pow(10, (numLength - i));
            result = result + array[i - 1];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int Num = Convert.ToInt32(Console.ReadLine());
        double Result = Sum(Num);
        Console.WriteLine("Сумма цифр равна: " + Result);
    }
}