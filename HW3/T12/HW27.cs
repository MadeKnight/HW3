// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

class Homework_27
{
    static int number;
    static int numlen;
    static int[] array;
    static void Main()
    {
        WelcomeNumber();
        Summ(array);
    }

    static void WelcomeNumber()
    {
        Console.WriteLine("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        int divider = 0;
        numlen = Size(number);
        array = new int[Size(number)];

        for (int i = 0; i < numlen; i++)
        {
            divider = Convert.ToInt32(Math.Pow(10, numlen - (i + 1)));
            array[i] = Convert.ToInt32(number / divider);
            number -= array[i] * divider;
            Console.WriteLine($"Цифра массива: {array[i]}");
        }
    }

    static int Size(int num)
    {
        int lenght = 0;
        int temp = num;

        while (temp > 0)
        {
            temp /= 10;
            lenght++;
        }

        return lenght;

    }
    static void Summ(int[] array)
    {
        int count = 0;

        foreach (int elem in array)
        {
            count += elem;
        }

        Console.WriteLine($"Сумма цифр в числе:{count}");
    }

}


