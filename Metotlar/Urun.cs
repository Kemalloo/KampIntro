using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //Property - Özellik (Aşağıdakilerin hepsi birer property'dir)
        public int Id { get; set; }       //Id = tc kimlik numarası gibi düşünülebilir.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public double StokAdedi { get; set; }


    }

}
