using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni bir müşteri eklendi. Müşteri Adı:" +musteri.Ad +" " + musteri.HesapNo);
        }

        public void MusteriDuzenle(Musteri musteri1)
        {
            Console.WriteLine("Müşteri bilgileri düzenlendi Yeni müşteri Adı: " + musteri1.Ad);
        }
    }
}
