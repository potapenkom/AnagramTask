using System;

namespace AnagramTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                throw new NullReferenceException("You entered an empty string");
            }
            UerInput uerInput = new UerInput(input);
            Console.WriteLine($"Inverted line: {uerInput.Reverse()}");
            Console.ReadKey();
        }
    }
}
