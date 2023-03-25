using System;

class Memeli
{
    protected double Boy;
    protected double Agirlik;

    public Memeli(double boy, double agirlik)
    {
        this.Boy = boy;
        this.Agirlik = agirlik;
        Console.WriteLine("Memeli hayvani olusturuldu. (yapici/kurucu metot)");
    }

    public void OzellikGoster()
    {
        Console.WriteLine("Boy: "+Boy);
        Console.WriteLine("Agirlik: "+Agirlik);
    }
}

class Kedi : Memeli
{
    public string Turu;
    public Kedi(string turu, int boy, int agirlik):base(boy,agirlik)
    {
        this.Turu = turu;
        Console.WriteLine("Kedi olusturuldu. (yapici/kurucu metot)");
    }

    public void TuruGoster()
    {
        Console.WriteLine(Turu + " Kedisi");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kedi kedi1 = new Kedi("van", 5, 10);
        kedi1.OzellikGoster();
        kedi1.TuruGoster();
        Console.WriteLine("**********");
        Memeli memeli1 = new Memeli(6,11);
        memeli1.OzellikGoster();
    }
}