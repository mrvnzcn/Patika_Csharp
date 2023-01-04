using System;

namespace diziler_array_sinifi_metots
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort

            
            int[] sayiDizisi = {23, 12, 65, 1, 15, 35, 28, 9};
            Console.WriteLine("SIRASIZ LİSTE");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("SIRALI LİSTE");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                
                Console.WriteLine(sayi);
            }
            //Clear
            Console.WriteLine("ARRAY CLEAR");
            Array.Clear(sayiDizisi,2,1);
            foreach (var sayi in sayiDizisi)

            {
                Console.WriteLine(sayi);    
            }
             //reverse
            Console.WriteLine("ters çevir CLEAR");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)

            {
                Console.WriteLine(sayi);    
            }
            Console.WriteLine("SIRALI LİSTE");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                
                Console.WriteLine(sayi);
            }
            Console.WriteLine("index of LİSTE");
            
            foreach (var sayi in sayiDizisi)
            {
                
                Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            }
            Console.WriteLine("resize LİSTE");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 123;
            foreach (var sayi in sayiDizisi)
            {
                
                Console.WriteLine(sayi);
            }
        }
    }
}