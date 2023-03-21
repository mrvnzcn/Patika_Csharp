using System;

namespace inheritance_dersi
{
    public class Hayvanlar:Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte olur.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Surungenler:Hayvanlar
    {
        
        
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler surunerek hareket eder.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();  
            base.UyaranlaraTepki();
        }
        
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}