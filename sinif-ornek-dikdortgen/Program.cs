using System;

namespace Dikdortgen_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
           Dikdortgen ornek1 = new Dikdortgen();
           ornek1.EnBoyBelirle(5,8,"Ahmet");
           ornek1.TumBilgileriYaz();

           Dikdortgen ornek2 = new Dikdortgen();
           ornek2.EnBoyBelirle(7,9,"Mehmet");
           ornek2.TumBilgileriYaz();

           Dikdortgen ornek3 = new Dikdortgen();
           ornek3.EnBoyBelirle(-7,9,"Can");
           ornek3.TumBilgileriYaz();

           Dikdortgen ornek4 = new Dikdortgen();
           ornek4.EnBoyBelirle(7,-9,"Firat");
           ornek4.TumBilgileriYaz();


        }
    }

    
}