using System;

namespace BreakAncContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Break b = new Break();
            b.Breakle(5);
            b.Continues(5);
        }
    }

    class Break
    {

        public void Breakle(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                if (i == 4) { break; }
                Console.WriteLine("Sayı" + i);   //çıktısı 0 1 2 3
                Console.ReadLine();
            }
        }

        public void Continues(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("Sayi"+i);  //çıktıtı 0 1 2 3 5
                Console.ReadLine();
            }
        }
    }
}
