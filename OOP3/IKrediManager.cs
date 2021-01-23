using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager              //"KrediManager"ebeveyn/base görevi görüyor. Buradaki "class" sildik. Onun yerine "interface" yazdık.
    {                                   //interface = arayüz, şablon. Interface kuralları içerir. Onu implemente eden class'lar o kuralları kendine göre doldurmak zorunda.
        void Hesapla();
        void BiseyYap();
    }


                                         //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
}
