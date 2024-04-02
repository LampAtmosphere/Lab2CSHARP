using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите X (между -1 и 1, не включая 1): ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Результат: " + CalcLn(1 - x, n));
    }

    static double CalcLn(double x, int n)
    {
        double sum = 0;
        for (int k = 1; k <= n; k++)
        {
            sum -= Math.Pow(x, k) / k;
        }
        return sum;
    }
}