using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1,"Anıl");
            myDictionary.Add(2, "Mehmet");
            myDictionary.Add(3,"Ahmet");

            Console.ReadLine();
        }
    }
}
