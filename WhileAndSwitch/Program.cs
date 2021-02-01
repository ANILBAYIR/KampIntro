using System;

namespace WhileAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Döngüsü");
            int number = 100;
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("now number is {0}", number);

            Console.WriteLine("Switch koşulu");

            var number1 = 50;

            switch (number1)
            {
                case 10:
                    Console.WriteLine("Yanlış");
                    break;
                case 20:
                    Console.WriteLine("Yanlış");
                    break;
                case 50:
                    Console.WriteLine("Doğru");
                    break;
                default:
                    Console.WriteLine("Geçersiz Yanıt");
                    break;
            }


            Console.ReadLine();
        }
    }
}
