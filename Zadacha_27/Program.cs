// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;

class GFG
{
    static int getSum(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }

        return sum;
    }

    public static void Main()
    {
        // int n = 452;
        // Console.Write(getSum(n));

        Console.Write("Vvedite: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(getSum(n));
    }
}
