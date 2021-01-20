using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)                                            
        {                                                                   
            Console.WriteLine(product.ProductName + "eklendi.");                     
        }


        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
     
        }






        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;                            //Void ne işe yarar ?? Void: Git, Yap, Bitir
        //}
                                                              //Emir kipinde işlem yaptırıyoruz. Eğer bu işlem sonucunda ekstra bir bilgiye ihtiyacımız yoksa biz onu 'void' diyoruz.                        
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
