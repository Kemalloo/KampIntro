using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product       //Entity gibi farklı isimler verilebilir. 
    {                                                   //Bu tip class'larda sadece özellik olur.
        public int Id { get; set; }
        public int CategoryId { get; set; }                        //--> Kod okunuruluğunu arttırmak için bu sırayla yazılması daha doğru. <--
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }




        
        
        
        
        
        
        
        //CRUD


    }
}
