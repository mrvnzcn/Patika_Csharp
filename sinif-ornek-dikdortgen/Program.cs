using System;

namespace Dikdortgen_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
           Dikdortgen ornek1 = new Dikdortgen();
           ornek1.EnBoyBelirle(5,8);
           ornek1.AlanHesapla();
        //    ornek1.TumBilgileriYaz(); 
        }
    }

    class Dikdortgen
    {
        public int En;
        public int Boy;

        public void EnBoyBelirle(int en, int boy)
        {
            En = en;
            Boy = boy;
        }

        public int AlanHesapla()
        {
            int alan = En * Boy;
            return alan;
        }

        public void TumBilgileriYaz()
        {
            Console.WriteLine("**********Dikdortgen Bilgileri*************");
            Console.WriteLine("Dikdortgenin En(cm): {0}",En);
            Console.WriteLine("Dikdortgenin Boy(cm): {0}",Boy);
            Console.WriteLine("Dikdortgenin Alan(cm): {0}",AlanHesapla());
        }
    }
}