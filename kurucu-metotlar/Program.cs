using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] ÖzelliklAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         //Metot komutları
            //     }
            // }

            //Erişim belirleyiciler
            // * Public -> her yerden erişilir
            // * Private -> tanımlandığı sınıf içerisinde erişilir
            // * Internal -> sadece kendi projesi içinde
            // * Protected -> sadece tanımlandığı sınıfta ve miras alan diğer tarafta alır

            Calisan calisan1 = new Calisan("Mervan","Ozcan",170215007,"Software Development");
            
            Console.WriteLine("****************Calisan1*********************");

            calisan1.CalisanBilgileri();

            Console.WriteLine("*************************************");

            Calisan calisan2 = new Calisan("Can","Yilmaz",248639876,"Product Development");
            
            Console.WriteLine("****************Calisan2*********************");
            calisan2.CalisanBilgileri();

            Console.WriteLine("******************Calisan3*******************");

            Calisan calisan3 = new Calisan("Jorge","Jesus");
            calisan3.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int CalisanNo;
        public string Departman;

        public Calisan(string ad, string soyad, int calisanno, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.CalisanNo = calisanno;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}",Ad);
            Console.WriteLine("Calisan Soyadi:{0}",Soyad);
            Console.WriteLine("Calisan No:{0}",CalisanNo);
            Console.WriteLine("Calisan Departmani:{0}",Departman);
        }
    }
}