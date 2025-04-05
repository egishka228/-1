using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число для генерации таблицы умножения: ");
        for (int number = 1; number <= 10; number++)
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }

        Console.WriteLine();



        Console.ReadLine(); 
    }
}
