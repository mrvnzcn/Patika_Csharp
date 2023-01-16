using System;

namespace Odev1
{
   class Program 
   {
    static void Main(string[] args)
    {
        Console.WriteLine("Pozitif bir tam sayı giriniz: ");
        int n = int.Parse(Console.ReadLine());
        
         string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Dizi kelimelerini giriniz: "+(i+1)+". kelime: ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Sondan başa kelimeler: ");
        for (int i=n-1; i >= 0; i--)
        {
               
        Console.WriteLine(words[i]);
            
        }
    }
   }
    
}