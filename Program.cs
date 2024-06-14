namespace attest;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Задача 1
        Console.WriteLine("Введите значения M и N для задачи 1 (через ввод):");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        PrintNaturalNumbers(m, n);

        // Задача 2
        Console.WriteLine("\nВведите значения m и n для функции Аккермана (через пробел):");
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        Console.WriteLine($"Результат функции Аккермана для {a} и {b}: {AckermannFunction(a, b)}");

        // Задача 3
        Console.WriteLine("\nВведите произвольный массив (через пробел):");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(array, array.Length - 1);
    }

    // Задача 1: Вывод натуральных чисел от M до N
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write($"{m} ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

    // Задача 2: Функция Аккермана
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }

    // Задача 3: Вывод элементов массива в обратном порядке
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{array[index]} ");
            PrintArrayReverse(array, index - 1);
        }
    }
}
