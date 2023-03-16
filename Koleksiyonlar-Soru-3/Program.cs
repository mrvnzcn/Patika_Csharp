using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cumle girin: ");
        string cumle = Console.ReadLine();

        char[] sesliler = new char[cumle.Length]; // sesli harfleri tutmak icin dizi
        int sesliSayisi = 0; // sesli harf sayisini tutmak icin degisken

        // cumledeki her karakteri kontrol et
        foreach (char c in cumle)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                sesliler[sesliSayisi] = c; // eger sesli harfse diziye ekle
                sesliSayisi++; // ve sesli harf sayisini 1 artir
            }
        }

        // sesli harfleri alfabetik sirada yazdir
        // Array.Sort(sesliler, 0, sesliSayisi);
        Console.Write("Sesli harfler: ");
        for (int i = 0; i < sesliSayisi; i++)
        {
            Console.Write(sesliler[i] + " ");
        }
    }
}