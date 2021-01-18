using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriNumarasi = 11111;
            Musteri1.Adi = "Berkay";
            Musteri1.Soyadi = "ŞAVKLI";
            Musteri1.DogumYili = 1995;

            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriNumarasi = 11112;
            Musteri2.Adi = "Nilay";
            Musteri2.Soyadi = "ŞAVKLI";
            Musteri2.DogumYili = 2001;

            Musteri[] musteriler = new Musteri[] { Musteri1,Musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID : " + musteri.MusteriNumarasi);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
                Console.WriteLine("Müşteri Doğum Yılı : " + musteri.DogumYili);
                Console.WriteLine("--------------------------------------");
            }

            MusteriManager musteriManager =new MusteriManager();
            musteriManager.Ekle(Musteri1);
            musteriManager.Ekle(Musteri2);
                

        }
    }
}
