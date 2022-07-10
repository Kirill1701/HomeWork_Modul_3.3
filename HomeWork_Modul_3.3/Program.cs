using System;

namespace HomeWork_Modul_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число\n");
            int n = int.Parse(Console.ReadLine());
            bool number = false;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    Console.Write(true);
                    i++;
                }
                else
                {
                    Console.Write(number);
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}
