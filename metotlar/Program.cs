using System;

namespace Metotlar
{
    class Program
    {
        static void Main(String[] args)
        {
            //erisim belirteçi geri_donustipi metot_Adi(parametrelistesi/Arguman)
            //{
                //komutlar
                //return
            //}

            int a = 2;
            int b = 3;
            int sonuc = Topla(a,b);
            Console.WriteLine(a+b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            int sonuc2 = ornek.ArttirveTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
       
       
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }


    }

    class Metotlar
    {
      public void EkranaYazdir(string veri)
      {
        Console.WriteLine(veri);
      }  

      public int ArttirveTopla(int deger1, int deger2)
      {
        deger1+=1;
        deger2+=1;
        return deger1 + deger2;
      }
    }
}
