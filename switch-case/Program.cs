using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //int month = DateTime.Now.Month;
            while (true) {
                Console.WriteLine("Bir ay giriniz:");
        
            int month = Convert.ToInt32(Console.ReadLine());
            //Expression
            switch (month)
            {
                case 1: 
                    Console.WriteLine("Ocak ayindasiniz.");
                    break;
                case 2: 
                    Console.WriteLine("Subat ayindasiniz.");
                    break;
                case 3: 
                    Console.WriteLine("Mart ayindasiniz.");
                    break;
                case 4: 
                    Console.WriteLine("Nisan ayindasiniz.");
                    break;
                case 5: 
                    Console.WriteLine("Mayis ayindasiniz.");
                    break;
                case 6: 
                    Console.WriteLine("Haziran ayindasiniz.");
                    break;
                case 7: 
                    Console.WriteLine("Temmuz ayindasiniz.");
                    break;
                case 8: 
                    Console.WriteLine("Agustos ayindasiniz.");
                    break;
                case 9: 
                    Console.WriteLine("Eylul ayindasiniz.");
                    break;
                case 10: 
                    Console.WriteLine("Ekim ayindasiniz.");
                    break;
                case 11: 
                    Console.WriteLine("Kasim ayindasiniz.");
                    break;
                case 12: 
                    Console.WriteLine("Aralik ayindasiniz.");
                    break;
                default:
                    Console.WriteLine("Yanlis veri girisi...");
                break;
            }
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kis mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Bahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11: 
                    Console.WriteLine("Guz mevsimindesiniz");
                    break;
                default:
                    Console.WriteLine("Yanlis veri girisi...");
                    break;
            
            }
            }
            
        }
    }
}