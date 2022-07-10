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

            while (n >= 1)
            {
                if (n % 2 == 0)
                {
                    Console.Write(true);

                }
                else
                {
                    Console.Write(number);
                }
                break;
            }

            Console.ReadKey();
        }
    }
}
