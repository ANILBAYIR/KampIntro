using System;

namespace OdevRefveOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ref veya out keyword kullanmadığımızda");

            int number1 = 20; 
            int number2 = 50;

            var result1 = Add(number1, number2); //number1 ve number2 değer tipi değişkenlerdir.Yani biz number1 ve number2ye denk gelen değerleri çağırmış oluruz.                                                
            Console.WriteLine(result1);
            Console.WriteLine(number1);  //Burada sadece number1'e karşılık gelen değeri çağırdık.
            //Eğer ref veya out keywordlerini kullanmazsak değer tiplerine metotlarda uygulanan değişiklikler sadece metot içinde kalır, dışarı yansımaz.


            Console.WriteLine("Ref keyword ile yazdığımızda");

            int number3 = 20;
            int number4 = 50;          


            var result2 = Add2(ref number3,number4);
            Console.WriteLine(result2);
            Console.WriteLine(number3);
            //Ref keyword kullandığımızda değer tipi değişkenler artık referans tipi değişkene dönüşür.
            //Metot içerisinde uygulanan değişikleri metot dışında da kalıcı hale gelir.

            Console.WriteLine("Out keyword ile yazdığımızda");

            int number5;
            int number6 = 50;


            var result3 = Add3(out number5, number6);
            Console.WriteLine(result3);
            Console.WriteLine(number5);
            //Out keyword kullandığımızdan ref'ten farklı olarak ilk değer atamam zorunluluğumuz yoktur.
            //Tamamen metot içindeki değişikliğe dayalı hale gelir.
            //Metot içinde değişiklik yapılması zorunludur.
            Console.ReadLine();
        }


        static int Add(int number1, int number2)
        {
            number1 = 30;
            var result1 = number1 + number2;
            return result1;
        }

        static int Add2(ref int number3, int number4)
        {
            number3 = 30;
            var result2 = number3 + number4;
            return result2;
        }

        static int Add3(out int number5, int number6)
        {
            number5 = 30;
            var result3 = number5 + number6;
            return result3;
        }
    }
}
