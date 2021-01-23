using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
          

            CarCrediManager carCrediManager = new CarCrediManager();

            
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> Loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), Loggers);          

            List<ICrediManager> credis = new List<ICrediManager>() { ihtiyacKrediManager, carCrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(credis);

        }
    }
}
