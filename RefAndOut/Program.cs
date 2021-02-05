using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Ref r = new Ref();
            double sayi;
            r.Toplam(out sayi);
            Console.WriteLine(sayi);
            
        }
    }

    class Ref
    {

        public void Toplam(out double number)
        {
            number = 11;
            number = number + Math.PI;
        }
    }
}
