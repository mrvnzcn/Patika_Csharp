using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //diger nesnelerden korumak? erişim belirleyciler ile yapılır. 
            //field'ı korumak için private tanımlarız
            //get set
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Mervan";
            ogrenci.Soyisim = "Ozcan";
            ogrenci.OgrenciNo = 961;
            ogrenci.Sinif = 6;

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Can","Yilmaz",578,1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci 
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get {return isim;}  
            set {isim = value;}  
        }

        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif=1;
                }
                else
                    sinif = value;
            }  
        }

        public Ogrenci(string isim = null, string soyisim = null, int ogrenciNo = 0, int sinif = 0)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*********** Öğrenci Bilgileri **********");
            Console.WriteLine("Öğrenci Adı      :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı      :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No      :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı      :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif =this.Sinif +1;
        }

        public void SinifDusur()
        {
            this.Sinif =this.Sinif -1;
        }
    }
}