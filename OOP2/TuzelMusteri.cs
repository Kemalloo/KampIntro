using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{    //Coorporate
    //miras (inheritance)  ------->  class TuzelMusteri:Musteri              ***"Musteri" burada ebeveyn durumundadır.***
    class TuzelMusteri :Musteri           //Özellik Class'ıdır. Buraya operasyon yazamayız. 
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
