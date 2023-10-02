// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using Microsoft.VisualBasic;

class Homework_25
{
    static int numX = 0;
    static int numY = 0;
    static void Main()
    {
        numX = WelcomeText("Введите X: ");
        numY = WelcomeText("Введите Y: ");
        Exponentiation(numX, numY);

    }
    static void Exponentiation(int x, int y)
    {
        int multipl = 1;

        for (int i = 0; i < y; i++)
        {
            multipl *= x;
        }

        Console.WriteLine($"Ваше чило: {multipl}");
    }

    static int WelcomeText(string msg)
    {
        Console.WriteLine(msg);
        return Convert.ToInt32(Console.ReadLine());
    }
}


