using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
       
       
       int[] allSayilardizi = new int[20];
       
       for (int i = 0; i < 20; i++)
       {
        Console.WriteLine("{0}. sayiyi giriniz: ",i+1);
        int allSayi;
        if (int.TryParse(Console.ReadLine(), out allSayi) && allSayi > 0)
            {
                allSayilardizi[i] = allSayi;
            }
            else
            {
                Console.WriteLine("Hatali giris, pozitif bir sayi giriniz.");
                i--;
            }
        allSayilardizi[i]=allSayi;
        
       } 

       
       ArrayList asalDegilList = new ArrayList();
       ArrayList asalList = new ArrayList();
       foreach (var item in allSayilardizi)
       {
        bool asaldir =true;
        for (int i = 2; i < item; i++)
        {
            if (item % i == 0)
            {
                asaldir = false;
                break;
            }
        }

        if (asaldir) 
        {
            
            asalList.Add(item);
        }
        else
        {
            
            asalDegilList.Add(item);
        }

       }

        asalDegilList.Sort();
        asalDegilList.Reverse();
        Console.WriteLine("*****buyukten kucuge asal olmayan sayilar*****");
       foreach (var item in asalDegilList)
       { 
        Console.WriteLine(item);
       }
       asalList.Sort();
        asalList.Reverse();
        Console.WriteLine("*****buyukten kucuge asal olan sayilar*****");
       foreach (var item in asalList)
       {
        Console.WriteLine(item);
       }
       int asalCount = asalList.Count;
       int asaldegilCount = asalDegilList.Count;
       Console.WriteLine("*****asal olan sayilarin eleman sayisi: {0}*****",asalCount);
       Console.WriteLine("*****asal olmayan sayilarin eleman sayisi: {0}*****",asaldegilCount);

       int toplamAsalList = 0;
       for (int i = 0; i<asalCount;i++)
       {
        toplamAsalList+=(int)asalList[i];
       }

       double ortalamaAsal = (double)toplamAsalList / asalCount;
       
       
       int toplamAsalDegilList = 0;
       for (int i = 0; i<asaldegilCount;i++)
       {
        toplamAsalDegilList+=(int)asalDegilList[i];
       }

       double ortalamaAsalDegil = (double)toplamAsalDegilList / asaldegilCount;
       Console.WriteLine("*****asal olan sayilarin eleman sayisi: {0}*****",ortalamaAsal);
       Console.WriteLine("*****asal olmayan sayilarin eleman sayisi: {0}*****",ortalamaAsalDegil);
    }
}
