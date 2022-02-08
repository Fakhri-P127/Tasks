using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            if (text.Contains('a'))
            {
                Console.WriteLine("a herfi var");

            }
            else
            {
                Console.WriteLine("a herfi yoxdu");
            }
        }
    }
}
