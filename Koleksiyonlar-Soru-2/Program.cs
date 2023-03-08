using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];

        //kullanicidan 20 sayi girmesini isteyiniz
        Console.WriteLine("Lutfen 20 sayi giriniz: ");
        for(int i=0;i<20;i++)
        {
            Console.WriteLine("{0}. sayi: ",i+1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        //en buyuk uc sayiyi bul
        Array.Sort(numbers);
        int sumOfMax = 0;
        Console.Write("En buyuk uc sayi: ");
        for(int i = 19; i>16;i--)
        {
            Console.Write("{0} ",numbers[i]);
            sumOfMax += numbers[i];
        }
        Console.WriteLine();

        //en kucuk uc sayi
        int sumOfMin = 0;
        Console.WriteLine("En kucuk 3 sayi: ");
        for(int i = 0; i<3;i++)
        {
            Console.Write("{0} ",numbers[i]);
            sumOfMin += numbers[i];
        }
        Console.WriteLine();

        //toplams n ortalamas
        double averageOfMax = (double)sumOfMax / 3;
        double averageOfMin = (double)sumOfMin / 3;
        Console.WriteLine("En büyük 3 sayinin ortalamasi: {0}", averageOfMax);
        Console.WriteLine("En küçük 3 sayinin ortalamasi: {0}", averageOfMin);
        Console.WriteLine("Ortalama toplamlari: {0}", averageOfMax + averageOfMin);

    }
}