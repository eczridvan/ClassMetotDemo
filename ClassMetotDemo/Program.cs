using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();

            musteri.Ad = "Hasan";
            musteri.Soyad = "Ali";
            musteri.Adres = "ANKARA";
            musteri.HesapNo = "TR12 2021 2154 6587 7849 21";
            musteri.Bakiye = 2542365206.54;

            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Osman Kale";

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.MusteriEkle(musteri1);
        }
    }
}
