using System;

namespace HomeWork_Modul_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число\n");
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            int i = 2;

            while (i < n) 
            {
                if (n % i == 0) 
                {
                    prime = false;
                    break;
                }
                i++;
            }

            if (prime == true)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не является простым");
            }

            Console.ReadKey();
        }
    }
}
