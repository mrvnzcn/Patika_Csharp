using System;

namespace inheritance_dersi
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte olur.");
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
        }
        
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}