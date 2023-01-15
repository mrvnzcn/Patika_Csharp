using System;

namespace metotoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısızdır!");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Aşırı Yükleme - overloading
            int ifade = 99;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("mervan","ozcan");

            //Metot imzası
            //metotAdi + parametre sayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
    }
