using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
   public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi"+urun.name);
        }

        public void Ekle2(string ad,string decription,int miktar)
        {
            Console.WriteLine("Tebbirkler sepete ürün eklendi" + ad);
        }

    }
}
