using System;

namespace Odev1
{
   class Program 
   {
    static void Main(string[] args)
    {
        Console.WriteLine("Pozitif bir tam sayı giriniz: ");
        int n = int.Parse(Console.ReadLine());
         int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Dizi elemanlarını giriniz: "+(i+1)+". eleman: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Çift sayılar: ");
        for (int i=0; i < n; i++)
        {
            if(numbers[i]%2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
   }
    
}