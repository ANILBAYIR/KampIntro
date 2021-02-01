using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","Kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");


            //Dictionary içerisinde tek bir değere ulaşmayı hedefliyosak aşağıdaki kodu yazıp çalıştırabiliriz.
            Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]); Dictionary içerisinde aradığımız key yoksa hata alırız.


            // Tüm dictionarydeki değerleri, anahtarları ve elemanları(değer+anahtar) görmek istiyorsak aşağıdaki foreach döngüsünü kullanırız.
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            
            //Bir değerin ya da anaharın dictionaryde olup olmadığını anlamak için ContainsKey ve ContainsValue metotlarını çalışıtırabiliriz.
            //Bu metotlar dictionary yapısına özgün olup koleksiyonlarda bulunmaz.
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsValue("masa"));
            Console.ReadLine();
        }
    }
}
