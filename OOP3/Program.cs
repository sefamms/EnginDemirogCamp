using System;
using System.Collections.Generic;

namespace OOP3
{
   public class Program
    {
        public static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(konutKrediManager,new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
        }
    }
}
