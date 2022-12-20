using System;

namespace degisken
{
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("");
        String degisken = " ";
        byte b = 5; //1 byte
        sbyte c = 5; //1 byte

        short s = 5; 
        ushort us = 5; //2 byte

        Int16 i16=2;
        int i = 2;
        Int32 i32 = 12;
        Int64 i64 = 2;
        uint a = 3;

        long l=4;
        ulong ul=12;
        float f = 4;
        double d = 2;

        char ch = '2';
        string str = "mervan";
        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        /*Console.WriteLine(dt);
        Console.WriteLine(b1);
        Console.WriteLine(str);*/

        object o1 ="x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        //string ifadeler

        string str1 = string.Empty;
        str1 = "Mervan Özcan";
        string ad = "Mervan";
        string soyad = "Özcan";
        string tamIsim = ad + " " + soyad;

        //integer ifadeler

        int integer1=5;
        int integer2=3;
        int integer3 = integer1 * integer2;

        //Console.WriteLine(integer3);

        // boolean

        bool bool11 = 10 < 2;
       // Console.WriteLine(bool11);

        // degisken dönüsümleri

        string str20 = "1231";
        int int20 = 20;

        string yeniDeger = str20 + int20.ToString();
       // Console.WriteLine(yeniDeger);
        
        string str30 = "1231";
        int int30 = 20;

        int yeniDeger2 = Convert.ToInt16(str30) + int30;
        Console.WriteLine(yeniDeger2);

        string datetime = DateTime.Now.ToString("HH");
        Console.WriteLine(datetime);

        



    }
}
} 