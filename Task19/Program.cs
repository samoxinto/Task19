using System;

namespace Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            string number = Console.ReadLine();

            string reversedStr = "";
            for (int i = number.Length - 1; i >= 0; i--)
                reversedStr += number[i];

            if (number == reversedStr)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

            Console.ReadLine();
        }
    }
}
