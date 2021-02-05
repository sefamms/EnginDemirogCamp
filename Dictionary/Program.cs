using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Dictionary sınıfı içinde bizim belirleyeceğimiz bir key'e uygun olarak değer saklar.
             zorunluluğu var
            2) Key türünü belirlememiz şart (sting, int ,decimal ,float
             */

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //veri etliyoruz.
            AdYas.Add("sefa", 32);
            AdYas.Add("ahmet", 34);
            AdYas.Add("deneem", 55);

            //değer sayma işlemi vardır
            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            var eleman = AdYas.Count;
            Console.WriteLine("eleman sayısı"+eleman);

            //silme özelliği vardır.
            AdYas.Remove("ahmet");
            Console.WriteLine();

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }


        }
    }
}
