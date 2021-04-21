using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number to convert to words");
            string number;
            Words convert = new Words();
            number = convert.NumbWords(int.Parse(Console.ReadLine()));
            Console.WriteLine(number);
        }
    }
}
