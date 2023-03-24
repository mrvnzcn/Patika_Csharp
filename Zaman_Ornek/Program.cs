using System;

namespace zamanornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaman z = new Zaman(5,59,60);
            z.ZamanBilgileriYaz();
        }
    }
	
	class Zaman 
    {
        public int Saat;
        public int Dakika;
        public int Saniye;

        public Zaman(int h, int m, int s)
        {
            ;
            Saniye = s % 60;
            int yeniDakika = m + s/60;
            Dakika = yeniDakika %60;
            Saat = h + yeniDakika/60;
        }

        public void ZamanBilgileriYaz()
        {
            Console.WriteLine("Saat:{0}",Saat);
            Console.WriteLine("Dakika:{0}",Dakika);
            Console.WriteLine("Saniye:{0}",Saniye);
        }
    } 

    
}