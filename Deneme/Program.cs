using System;

namespace Deneme
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Acer";
            urun1.Fiyati = 5600;
            urun1.Aciklama = "Laptop";
            urun1.Ozellikleri = "AMD Ryzen 7 işlemci, AMD Radeon RX Vega 10 ekran kartı, 512 GB SSD";

            Urun urun2 = new Urun();
            urun2.Adi = "MSI";
            urun2.Fiyati = 12500;
            urun2.Aciklama = "Masaustu";
            urun2.Ozellikleri = "Intel Core i7 işlemci, Nvidia GeForce RTX 2060 Super ekran kartı, 1 TB SSD";

            Urun urun3 = new Urun();
            urun3.Adi = "Iphone";
            urun3.Fiyati = 12500;
            urun3.Aciklama = "Akıllı Telefon";
            urun3.Ozellikleri = "iPhone OS işlemci, 12MP+12MP kamera çözünürlüğü, 64 GB hafıza";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Ozellikleri);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("======= foreach bitti ======");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Adi);
                Console.WriteLine(urunler[i].Fiyati);
                Console.WriteLine(urunler[i].Aciklama);
                Console.WriteLine(urunler[i].Ozellikleri);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("======= for bitti ======");

            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine(urunler[x].Adi);
                Console.WriteLine(urunler[x].Fiyati);
                Console.WriteLine(urunler[x].Aciklama);
                Console.WriteLine(urunler[x].Ozellikleri);
                Console.WriteLine("-------------------");
                x++;
            }
            Console.WriteLine("======= while bitti ======");
            




        }

    }
    class Urun
    {
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public string Ozellikleri { get; set; }
    }
}
