using System;

class Program
{
    static void Main()
    {
        int n;
        double x;

        do
        {
            Console.Write("Введите N (целое число): ");
        }
        while (!int.TryParse(Console.ReadLine(), out n));

        do
        {
            Console.Write("Введите X (между -1 и 1, не включая 1): ");
        }
        while (!double.TryParse(Console.ReadLine(), out x) || x <= -1 || x >= 1);

        Console.WriteLine($"Результат: {CalcLn(1 - x, n)}");
    }

    static double CalcLn(double x, int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(x, i) / i;
        }
        return -sum;
    }
}