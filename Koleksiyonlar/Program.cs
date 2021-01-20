using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Lefter", "Alex", "Can Bartu", "Özil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "Volkan";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
                                                                        //Genellikle pek arrey kullanmayız. Onun yerine koleksiyonları kullanırız.

            List<string> isimler2 = new List<string> { "Lefter", "Alex", "Can Bartu", "Özil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
                                                                           
            isimler2.Add("Volkan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
