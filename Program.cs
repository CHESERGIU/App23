using System;

namespace App23
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;            
            int sum = 0;
            do
            {
                input = Console.ReadLine();
                if (input == "x")
                    break;
                sum += int.Parse(input);
            } while (!(input == "x"));
            Console.WriteLine(sum);            
        }
    }
}
