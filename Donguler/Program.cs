using System;

namespace Donguler
{
    class Program
    {

        //birbirini tekrar eden şeyler için döngüleri kullanırız.
        //'++' demek birer birer arttır demektir
        //'kurslar' diyerek burada istediğimiz kadar kurs tutabiliriz. Tek tek tanımlama yerine, tek bir array'de tutuyoruz.
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";             //bunlar döngülerde değil dizilerde yapılır!!
            string kurs2 = "Programlaya Başlangıç için Temel Kurs";           //bunlar döngülerde değil dizilerde yapılır!!
            string kurs3 = "Java";                                           //bunlar döngülerde değil dizilerde yapılır!!
            string kurs4 = "Python";                                        //bu tip veriler (array=dizi) dizilerde tutulur.
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlaya Başlangıç için Temel Kurs", "Java", "Python", "C++"};       
            

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)                //'foreach' diziler or dizi temelli yapıları tek tek dönmeye/dolaşmaya yarar.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
