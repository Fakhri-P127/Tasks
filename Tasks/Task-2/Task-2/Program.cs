using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"Code Academy","Ordek","Chainsaw","Git","Github","Gitbash","Task" };
            foreach (string word in words)
            {
                if (word.Length > 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
