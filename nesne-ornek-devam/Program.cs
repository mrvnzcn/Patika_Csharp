using System;

class Memeli 
{
    protected double mBoy;
    protected double mAgirlik;

    public Memeli(double boy, double agirlik)
    {
        this.mBoy = boy;
        this.mAgirlik = agirlik;
    }

    public void OzellikGoster()
    {
        Console.WriteLine("Boy: " + mBoy);
        Console.WriteLine("Agirlik: " + mAgirlik);
    }

    public double Boy
    {
        get{return mBoy;}
        set{mBoy = value;}
    }

    public double Agirlik
    {
        get{return mAgirlik;}
        set{mAgirlik = value;}
    }
}

class Kedi : Memeli
{
    public string Turu;
    public Kedi(string turu, int boy, int agirlik):base(boy,agirlik)
    {
        this.Turu = turu;
    }

    public void TurGoster()
    {
        Console.WriteLine("Kedi Turu: " + Turu);
    }
}

class Koyun : Memeli
{
    public string Turu;
    public Koyun(string turu, int boy, int agirlik):base(boy,agirlik)
    {
        this.Turu = turu;
    }

    public void TurGoster()
    {
        Console.WriteLine("Koyun Turu: "+Turu);
    }
}

class MainMetodu
{
    public static void Goster(Memeli memeli1)
    {
        Console.WriteLine("Boy: ",memeli1.Boy);
        Console.WriteLine("Agirlik: ",memeli1.Agirlik);
    }

    static void Main()
    {
        Memeli memeli1 = new Memeli(10,20);
        Kedi kedi1 = new Kedi("van", 5, 10);

        object o1 = memeli1;
        object o2 = kedi1;

        Console.WriteLine(o1.ToString());
        Console.WriteLine(o2.ToString());
    }
}