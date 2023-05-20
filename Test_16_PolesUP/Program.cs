using System;

namespace Test_16_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Ведите число");
                double number = Convert.ToInt32(Console.ReadLine());
                int Count = Convert.ToInt32(Math.Log(number, 3));
                
                double X;
                do
                {
                    X = Math.Pow(3, Count);
                    number -= X;
                    if (number < 0)
                    {
                        number += X;
                    }
                    Count--;

                } while (number != 0 && Count > 0);

                if (number == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
