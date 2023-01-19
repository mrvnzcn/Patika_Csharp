using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz GS";
            string degisken2 = "Dersimiz GS";
            //LENGTH
            Console.WriteLine(degisken.Length);
            //TOUPPER
            Console.WriteLine(degisken.ToUpper());
            //TOLOWER
            Console.WriteLine(degisken.ToLower());
            //CONCAT
            Console.WriteLine(string.Concat(degisken,"çok yaşa"));
            //COMPARETO
            Console.WriteLine(degisken.CompareTo(degisken2));
            //COMPARE
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            //CONTAINS
            Console.WriteLine(degisken.Contains(degisken2));
            //EndsWith
            Console.WriteLine(degisken.EndsWith("aaa"));
            //StartWith
            Console.WriteLine(degisken.StartsWith("aaa"));
            //IndexOf
            Console.WriteLine(degisken.IndexOf("GS"));
            //INSERT
            Console.WriteLine(degisken.Insert(0,"AAA "));
            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf(""));
            //PadLeft
            Console.WriteLine(degisken2 + degisken.PadLeft(30,'*'));
            //PadRight
            Console.WriteLine(degisken2 + degisken.PadRight(30,'*'));
            //Remove
            Console.WriteLine(degisken.Remove(5,4));
            //Replace
            Console.WriteLine(degisken.Replace("i","a"));
            //Split
            Console.WriteLine(degisken.Split(' ')[1]);
            //Substring
            Console.WriteLine(degisken.Substring(4));
        }
    }
}