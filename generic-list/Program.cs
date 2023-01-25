using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic namespace altından gelmektedir.
            // T -> object türündedir, nesne alabilir. nesnelerin tipini ifade ediyor.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Yesil");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve list.foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi )
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi )
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Kirmizi");
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //liste içinde searching
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu");
            }
            else
            {
                Console.WriteLine("10 liste içinde bulunamadi");
            }

            
            
            //eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Yesil"));
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));
            Console.WriteLine(renkListesi.BinarySearch("Sari"));


            //Diziyi List'e çevirme
            string[] hayvanlar = {"kedi","kopek","at"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //List temizlemece
            hayvanListesi.Clear();


            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Mervan";
            kullanici1.Soyisim ="Ozcan";
            kullanici1.Yas = 25;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Mehmet";
            kullanici2.Soyisim ="Soyer";
            kullanici2.Yas=26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="Can",
                Soyisim="Yilmaz",
                Yas=25
            
            });

            foreach(var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi:" +kullanici.Isim);
                Console.WriteLine("Kullanici Soyadi:" +kullanici.Soyisim);
                Console.WriteLine("Kullanici Yasi:" +kullanici.Yas);
            }



        }
    }


    public class Kullanicilar {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}