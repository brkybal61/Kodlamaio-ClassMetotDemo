using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdı + " " + musteri.MusteriSoyadı + " isimli kişiyi banka kaydına eklediz.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdı + " " + musteri.MusteriSoyadı + " isimli kişiyi banka kaydından sildiniz.");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdı + " " + musteri.MusteriSoyadı);
        }
    }
}
