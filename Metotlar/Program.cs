using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;                                 //Burada yazmıştık ama bu şekilde yazdığımızda, bunların bir ürünü ifade ettiğini açıklayamıyoruz.
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] {urun1,urun2 };           //arrey= bir veri tipinde ne kadar data eklersek ekleyelim, o datayı tutan yapıdır.
                                                                  //Gerçek hayatta da aynen böyledir(Satır 25de yazan urun1,urun2 normalde bir veri kaynağından gelir gerçek hayatta).
                                                                 //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");

            }


            Console.WriteLine("-------------------------------------Metotlar-------------------------------------");

            //instance - örnek
            //encapsulation - kapsülleme
            SepetManager  sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}

//Don't repeat yourself - DRY - Clean Code - Best Practice
