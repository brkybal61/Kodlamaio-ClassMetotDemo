using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdı = "Berkay";
            musteri1.MusteriSoyadı = "Bal";
            musteri1.Mail = "berkaybal@icloud.com";
            musteri1.Telefon = "0555 555 55 55";
            musteri1.Adres = "Emirgan Sahil";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdı = "Süleyman";
            musteri2.MusteriSoyadı = "Bal";
            musteri2.Mail = "suleymanbal@icloud.com";
            musteri2.Telefon = "0555 555 56 56";
            musteri2.Adres = "Zeytinburnu Beko'nun Üstü";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdı = "Atahan";
            musteri3.MusteriSoyadı = "Bal";
            musteri3.Mail = "atahanbal@icloud.com";
            musteri3.Telefon = "0555 555 61 61";
            musteri3.Adres = "Ankara Kızılay Caddesi";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdı = "Suat";
            musteri4.MusteriSoyadı = "Bal";
            musteri4.Mail = "suatbal@icloud.com";
            musteri4.Telefon = "0555 555 57 57";
            musteri4.Adres = "Londra";

            Musteri musteri5 = new Musteri();
            musteri5.MusteriAdı = "Hamza";
            musteri5.MusteriSoyadı = "Bal";
            musteri5.Mail = "hamzabal@icloud.com";
            musteri5.Telefon = "0555 555 58 58";
            musteri5.Adres = "Bahçeşehir";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Bankanıza Kaydı Eklenmiş Müşteriler:");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Bankanızın Kaydından Silinmiş Müşteriler:");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);
            musteriManager.MusteriSil(musteri5);


            Console.WriteLine("\nMüşteri Listesi");
            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.MusteriListele(musteriler[i]);
            }


        }
    }
}
