using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler de onu implemente eden sınıfın referansını tutabilir.
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { smsLoggerService, fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {esnafKrediManager, ihtiyacKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);


        }
    }
}
