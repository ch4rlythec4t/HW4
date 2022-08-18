using System;
class Program
{
    static double PowNatural(int Num, int Pow)
    {
        int result = 1;
        for (int i = 1; i <= Pow; i++)
        {
            result = result * Num;
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Введите число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите натуральную степень: ");
        int B = Convert.ToInt32(Console.ReadLine());

        double Result = PowNatural(Num: A, Pow: B);
        Console.WriteLine($"Результат: {Result}");
    }
}