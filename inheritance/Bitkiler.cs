using System;

namespace inheritance_dersi
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
        }
        public void TohumlaUreme()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla urer");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
        }
        
        public void TohumsuzUreme()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla urer");
        }
    }
}