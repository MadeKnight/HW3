// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


class Homework_29
{
    static int number;
    static int numlen;
    static int maxLenArray = 8;
    static int[] array;
  
    static void Main()
    {
        WelcomeNumber();
    }

    static void WelcomeNumber()
    {
        Console.WriteLine("Введите число чтобы задать массив: ");
        number = Convert.ToInt32(Console.ReadLine());
        int divider = 0;
        numlen = Size(number);
        array = new int[maxLenArray];


        for (int i = 0; i < maxLenArray; i++)
        {
            divider = Convert.ToInt32(Math.Pow(10, numlen - (i + 1)));
            if(divider <= 0) break;
            array[i] = Convert.ToInt32(number / divider);
            number -= array[i] * divider;
            Console.WriteLine(array[i]);
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
}


