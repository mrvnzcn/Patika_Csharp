using System;

namespace inheritance_dersi
{
    class Program
    {
        static void Main(string[] args)
        {
            //                Canlılar
            //      Bitkiler            Hayvanlar
            // Tohumlu Tohumsuz     Surungenler Kuslar

            TohumluBitkiler tohumluBitki1 = new TohumluBitkiler();
            // tohumluBitki1.Beslenme();
            // tohumluBitki1.Solunum();
            // tohumluBitki1.Bosaltim();
            tohumluBitki1.TohumlaUreme();
            //tohumluBitki1.Fotosentez();
            
            Console.WriteLine("**********************");

            Kuslar marti = new Kuslar();
            //marti.Adaptasyon();
            // marti.Beslenme();
            // marti.Bosaltim();
            // marti.Solunum();
            marti.Ucmak();

        }
    }
}