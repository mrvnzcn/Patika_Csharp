using System;

namespace inheritance_dersi
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar Beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar Solunur.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlilar Bosaltir.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }

    }
}