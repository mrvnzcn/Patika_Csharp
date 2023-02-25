using System;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add(10,"Mervan Özcan");
            kullanıcılar.Add(12,"Can Yılmaz");
            kullanıcılar.Add(18, "Kerem Aslı");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);
            
            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("iso"));
            Console.WriteLine(kullanıcılar.ContainsValue("Kerem Aslı"));

            //Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item.Value);

            //Keys
            Console.WriteLine("***** Keys *****");
            
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);

            //Values
            Console.WriteLine("***** Values *****");
            
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);


            
        }
    }
}