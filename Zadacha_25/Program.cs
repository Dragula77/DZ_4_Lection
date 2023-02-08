// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

static int Method(int a, int b)
{
    int Result = 1;
    for (int i = 0; i < b; i++)
    {
        // Console.WriteLine("Первое число в степени второго равно:" + Result);
        Result = Result * a;
    }
    return Result;
}
// Method(2,4);
System.Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень : ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Method(a,b));
