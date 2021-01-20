using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";                           //Aşağıda görülen 'product2' farklı bir yazım şeklidir !!!
            product1.UnitPrice = 500;                                //Aslında bu yazdığımız veriler bir data'dan gelir. Biz yazmayız.
            product1.UnitsInStock = 3;


            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};


            //PascalCase   //camelCase                                          // ---->  !!! Bunlar Çok Önemli İsimlendirme Kuralları !!!
            //case sensitive
            ProductManager productManager = new ProductManager();               //Aslında bunu yapıyoruz ---> string isim = "Kemal";
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



        }
    }
}
