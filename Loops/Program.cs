using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım Geliştirici Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java","Angular5" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
