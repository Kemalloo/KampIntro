using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Barcelona");
            sehirler2.Add("Barcelona");
            sehirler2.Add("Barcelona");
            sehirler2.Add("Barcelona");
            sehirler2.Add("Barcelona");
            Console.WriteLine(sehirler2.Count);


        }

        class MyList<T>     //Generic class
        {
            T[] array;
            T[] tempArray;

            public MyList()
            {
                array = new T[0];
            }


            public void Add(T item)
            {
                tempArray = array;
                array = new T[array.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    array[i] = tempArray[i];
                }

                array[array.Length - 1] = item;
            }


            public int Count
            {
                get { return array.Length; }
                
            }

        }

    }
}
