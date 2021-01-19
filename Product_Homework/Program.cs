using System;

namespace Product_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.TelefonAdi = "İphone XR";
            Urun1.TelefonMarkasi = "Apple";
            Urun1.Telefonfiyati = 799;

            Product Urun2 = new Product();
            Urun2.TelefonAdi = "Samsung S20";
            Urun2.TelefonMarkasi = "Samsung";
            Urun2.Telefonfiyati = 599;

            Product Urun3 = new Product();
            Urun3.TelefonAdi = "LG G3";
            Urun3.TelefonMarkasi = "LG";
            Urun3.Telefonfiyati = 299;

            
            Product[] products = new Product[] { Urun1, Urun2, Urun3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }


            foreach (var Urun in products)
            {
                Console.WriteLine(Urun.TelefonAdi + Urun.TelefonMarkasi + Urun.Telefonfiyati);
            }

            
        }
    }
}
class Product
{
    public string TelefonAdi { get; set; }
    public string TelefonMarkasi { get; set; }
    public int Telefonfiyati { get; set; }



}