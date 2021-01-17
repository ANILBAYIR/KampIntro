using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+"Id numarasına sahip"+" "+musteri.AdiSoyadi +" "+"sisteme eklendi :)");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+ "Id numarasına sahip" + " " + musteri.AdiSoyadi + " " + "sistemden silindi :(");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri x in musteriler)
            {
                Console.WriteLine("ID:"+" "+x.Id);
                Console.WriteLine("Adı Soyadı:"+" "+x.AdiSoyadi);
                Console.WriteLine("Cinsiyeti:"+" "+x.Cinsiyet);
                Console.WriteLine("Yaşı:"+" "+x.Yasi);
                Console.WriteLine("Mesleği:"+" "+x.Meslek);
                Console.WriteLine("-------------------");
            }
        }
    }
}
