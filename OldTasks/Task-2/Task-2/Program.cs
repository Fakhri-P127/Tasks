using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine()) ;
            if (number % 2 == 0)
            {
                Console.WriteLine("cutdur");
            }
            else
            {
                Console.WriteLine("tekdir");
            }
        }
    }
}
