using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Kampı";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 89;
            kurs1.katilimciSayisi = 1230;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Işıl Beyza Durak";
            kurs2.izlenmeOrani = 99;
            kurs2.katilimciSayisi = 3327;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Alper Buğra Polat";
            kurs3.izlenmeOrani = 80;
            kurs3.katilimciSayisi =9477;

            //Console.WriteLine(kurs1.KursAdi + " \n" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + "\t" + kurs.izlenmeOrani + 
                    " Katılımcı Sayısı: " + kurs.katilimciSayisi);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
        public int katilimciSayisi { get; set; }


    }
}
