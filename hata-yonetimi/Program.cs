﻿using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try {
            //     Console.WriteLine("Bir sayi giriniz:");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmiş olduğunuz sayi:" + sayi);
            //     }
            //     catch (Exception ex) 
            //     {
            //         Console.WriteLine("Hata:" + ex.Message.ToString());
            //     }
                //finally 
                //{
                //    Console.WriteLine("İşlem tamamlandi.");
                //}
                try
                {
                    //int a = int.Parse(null);
                    //int a = int.Parse("test");
                    int a = int.Parse("-20000000000");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Boş değer girdiniz.");
                    Console.WriteLine(ex);
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Veri tipi uygun değil");
                    Console.WriteLine(ex);
                    
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("çko küçük/büyük değer girdiniz");
                    Console.WriteLine(ex);
                    
                }
            
        }
    }
}