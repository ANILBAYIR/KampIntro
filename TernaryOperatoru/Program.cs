using System;

namespace TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11;
            Console.WriteLine(number == 10 ? "Number is 10":"Number is not 10");

            int age = 24;
            string result = age < 25 ? "A": ( age == 25 ? "B" :"C");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
