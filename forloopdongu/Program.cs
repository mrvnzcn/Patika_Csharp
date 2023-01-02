using System;

namespace dongulerforloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            
            Console.WriteLine("Bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++) 
            {
                if (i%2 == 1)
                    Console.WriteLine(i);
            }
            
            int tekToplam = 0;
            int ciftToplam = 0;
            Console.WriteLine("Bir sayi giriniz: ");
            int sayac2 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= sayac2; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;
                else if (i%2 == 0)
                    ciftToplam += i;

            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Cift Toplam:" + ciftToplam);
            
           // break & continue
           for (int i = 1; i < 10; i++)
           {
                if(i==4)
                    break;
                Console.WriteLine(i);
           }
           for (int i = 1; i < 10; i++)
           {
                if(i==4)
                    continue;
                Console.WriteLine(i);
           }
        }
    }
}