using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 123456;
            musteri1.AdiSoyadi = "Ali Bir";
            musteri1.Cinsiyet = "Erkek";
            musteri1.Yasi = 30;
            musteri1.Meslek = "Bilgisayar Mühendisi";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 123457;
            musteri2.AdiSoyadi = "Ayşe İki";
            musteri2.Cinsiyet = "Kadın";
            musteri2.Yasi = 25;
            musteri2.Meslek = "Endüstri Mühendisi";

            Musteri musteri3 = new Musteri();

            musteri3.Id = 123458;
            musteri3.AdiSoyadi = "Ahmet Üç";
            musteri3.Cinsiyet = "Erkek";
            musteri3.Yasi = 35;
            musteri3.Meslek = "Makina Mühendisi";

            Musteri musteri4 = new Musteri();

            musteri4.Id = 123459;
            musteri4.AdiSoyadi = "Fatma Dört";
            musteri4.Cinsiyet = "Kadın";
            musteri4.Yasi = 40;
            musteri4.Meslek = "Doktor";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            Console.WriteLine("-----Sisteme ekleme işlemi tamamlanmıştır.-----");
            musteriManager.Listele(musteriler);
            Console.WriteLine("-----Mevcut müşterileri listeleme işlemi tamamlanmıştır.-----");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);
            Console.WriteLine("-----Sistemden silme işlemi tamamlanmıştır.-----");
            

            Console.ReadLine();









        }
    }

    
    
}
