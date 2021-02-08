using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri {
                Id = 1,
                Ad = "Ali",
                Soyad = "Yılmaz",
                Sehir = "Kocaeli"
            };
            Musteri musteri2 = new Musteri {
                Id = 1,
                Ad = "Ayşe",
                Soyad = "Öz",
                Sehir = "İstanbul"
            };
            Musteri musteri3 = new Musteri{
                Id = 1,
                Ad = "Burak",
                Soyad = "Kılıç",
                Sehir = "Bursa"
            };
            

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("Musteriler Listeleniyor.....");
            musteriManager.Listele();
            
            musteriManager.Sil(musteri2);
            Console.WriteLine("Musteriler Listeleniyor.....");
            musteriManager.Listele();

            

        }
    }
}
