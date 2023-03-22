using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus1 = new Focus();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            Fabia fabia1 = new Fabia();
            Console.WriteLine(fabia1.HangiMarkaninAraci().ToString());
            Console.WriteLine(fabia1.KacTekerlektenOlusur());
            Console.WriteLine(fabia1.StandartRengiNe().ToString());
        }
    }
}