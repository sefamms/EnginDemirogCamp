using System;

namespace Metodlar
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            Urun urun1 = new Urun();
            urun1.description = "niğde elması";
            urun1.fiyat = 90;
            urun1.name = "Elma";

            Urun urun2 = new Urun();
            urun2.name = "karpuz";
            urun2.description = "diyarbakır karpuzu";
            urun2.fiyat = 300;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.fiyat);
                Console.WriteLine(urun.description);
                Console.WriteLine(urun.name);
                
            }

            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun2);
            sepet.Ekle(urun1);


            sepet.Ekle2("Armut", "Yeşil Armut", 12);
            sepet.Ekle2("Elma", "Sarı elma", 12);
            sepet.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);
        }




    }
}
