using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself!
            //kategoriEtiketi = bir değer tutucu, alias (bizim için bir kodsal anlamı var artık)
            //if () { } = şart geçerliyse süslü parantez içi çalışsın. Hızlı yazmak için 'if' yaz iki kere 'tab'a bas.
            //17.satırdaki yazan 'true' gerçek hayatta bir veri kaynağından gelir.
            //kodlar yukarıdan aşağıya doğru çalışır

            //değişkenler
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //şartblokları
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
