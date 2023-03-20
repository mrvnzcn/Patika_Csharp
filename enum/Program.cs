using System;

namespace enum_yapilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Sali);

            int sicaklik = 32;

            if (sicaklik<= (int)havaDurumu.Normal)
            {
                Console.WriteLine("disariya cikmak icin havanin biraz daha isinmasini bekle.");
            }
            else if (sicaklik>=(int)havaDurumu.Sicak)
            {
                Console.WriteLine("disariya cikmak icin sicak bi gun");
            }
            else if(sicaklik>=(int)havaDurumu.Normal && sicaklik<(int)havaDurumu.cokSicak);
            {
                Console.WriteLine("hadi disariya cikalim!");
            }
        }
    }

    enum Gunler 
    {
        Pazartesi=-3,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum havaDurumu 
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        cokSicak=35,
        cokSoguk=-5
    }
}