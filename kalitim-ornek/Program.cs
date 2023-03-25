using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Kediler kedi1 = new Kediler();
            kedi1.agirlik=30;
            kedi1.boy=50;
            kedi1.ayakSayisi=4;
            kedi1.Tur="Van";

            kedi1.OzellikGoster();
            kedi1.TurGoster();
            Console.WriteLine("*******************");

            Kediler kedi2 = new Kediler();
            kedi2.agirlik=40;
            kedi2.boy=60;
            kedi2.ayakSayisi=4;
            kedi2.Tur="Iran";

            kedi2.OzellikGoster();
            kedi2.TurGoster();
            Console.WriteLine("*******************");
            
            
        }
    }

    class Memeliler
    {
        public int boy;
        public int agirlik;
        public int ayakSayisi;
        public void OzellikGoster()
        {
            Console.WriteLine("boy:{0}",boy);
            Console.WriteLine("agirlik:{0}",agirlik);
            Console.WriteLine("ayakSayisi:{0}",ayakSayisi);
        }
    }

    class Kediler : Memeliler
    {
        public string Tur;

        public void TurGoster()
        {
            Console.WriteLine(Tur + " Kedisi");
        }

    }
}