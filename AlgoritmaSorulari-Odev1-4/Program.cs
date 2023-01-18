using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            Console.WriteLine("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine("Kullanılan kelimeler: "+kelimeler[i]);
            }
            
            int kelimeSayisi = kelimeler.Length;
            Console.WriteLine("Kelime Sayısı: " +kelimeSayisi);

            string forharfSayisiCumle = cumle.Replace(" ", "");
            int harfSayisi = forharfSayisiCumle.Length;

            Console.WriteLine("Harf Sayısı: " +harfSayisi);
        }
    }
}
