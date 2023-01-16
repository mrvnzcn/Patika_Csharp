using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - öz yinelemeli
            // 3^4 önce for sonra rekürsif
            int result = 1;
            for (int i = 1; i<5; i++)
                result = result * 3;
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));
            //Extension Metotlar
            string ifade = "ismail Mervan özcan";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLoweeCase());

            int[] dizi = {9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();
            int sayi = 5;
            Console.WriteLine(sayi.IsEven());
            Console.WriteLine(ifade.getFirstChar());

        }

        public class Islemler{
            public int Expo(int sayi, int üs)
            {
                if(üs<2)
                    return sayi;
                return Expo(sayi,üs-1)* sayi;
            }
        }
    }   //Expo 3,4
        //expo 3,3 *3
        //expo 3,2 *3*3
        //expo 3,1 3*3*3
        //expo 3*3*3*3

        public static class Extension{
            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpaces(this string param)
            {
                string[] dizi = param.Split(" ");
                return string.Join("*",dizi);
            }

            public static string MakeUpperCase(this string param)
            {
                return param.ToUpper();
            }
            public static string MakeLoweeCase(this string param)
            {
                return param.ToLower();
            }

            public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }

            public static void EkranaYazdir(this int[] param)
            {
                foreach (int item in param)
                Console.WriteLine(item);
            }
            public static bool IsEven(this int param)
            {
                return param%2 == 0;
                
            }
            public static string getFirstChar(this string param)
            {
                return param.Substring(0,1);
                
            }
        }
}