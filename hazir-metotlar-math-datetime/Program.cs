﻿using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(3));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(3));
            Console.WriteLine(DateTime.Now.AddMilliseconds(3));

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));



            //Math

            Console.WriteLine(Math.Abs(-25)); //mutlak değer
            Console.WriteLine(Math.Sin(25));//sinüs
            Console.WriteLine(Math.Cos(25));
            Console.WriteLine(Math.Tan(25));

            Console.WriteLine(Math.Ceiling(25.34));
            Console.WriteLine(Math.Round(25.34));
            Console.WriteLine(Math.Round(25.84));
            Console.WriteLine(Math.Floor(25.34)); //double, float

            Console.WriteLine(Math.Max(25,34));
            Console.WriteLine(Math.Min(25,34));

            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Max(25,34));
            Console.WriteLine(Math.Log2(16));
            Console.WriteLine(Math.Exp(3)); //e ^ 3


            

            
        }
    }
}