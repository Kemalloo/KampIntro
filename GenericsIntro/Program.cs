﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kemal");

            Console.WriteLine(isimler.Length);

            isimler.Add("Lefter");

            Console.WriteLine(isimler.Length);


        }
    }
}
