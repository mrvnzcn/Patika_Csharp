using System;

namespace whileforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //while ile 1'den başlayarak console'dan girilen sayıya kadar ortalama yaz, bastır
            Console.Write("Sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi) 
            {
                toplam+=sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);

            //a'dan z'ye tüm harfleri bas
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.Write(karakter);
                karakter++;
            }

            Console.Write("***** foreach *****");
            string[] arabalar = {"bmw", "skoada", "toyota", "nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}