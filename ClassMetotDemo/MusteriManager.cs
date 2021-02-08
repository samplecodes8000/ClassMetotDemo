using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Ad +" eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.Ad + " silindi.");
        }
        public void Listele()
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id +" "+ musteri.Ad +" "+ musteri.Soyad +" "+ musteri.Sehir);
            }
        }

    }
}
