using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kemal Can Bayram
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kemal";
            musteri1.Soyadi = "Bayram";
            musteri1.TcNo = "1234567890";


            //Kodlama.io


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID


            Musteri musteri3 = new GercekMusteri();             //Eşitliğin sağ tarafı ----> "Referans No'su"
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }
}
