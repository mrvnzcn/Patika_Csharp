using System;
namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayse","Yilmaz","HR");
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("fATMA","ÇİÇEK","HR");
            Calisan calisan2 = new Calisan("ALİ","erbil","HR");
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Cikarma: {0}", Islemler.Cikar(300,200));
            
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;  }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman = null)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }

        
    }

    static class Islemler
        {
            public static long Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public static long Cikar(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }
}