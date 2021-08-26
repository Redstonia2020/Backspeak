using System;

namespace Backspeak
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    char[] charArray = Console.ReadLine().ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(new string(charArray));
                }

                catch (Exception e)
                {
                    Console.WriteLine("We seem to have encountered a problem.");
                    Console.WriteLine(e);
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }
    }
}
