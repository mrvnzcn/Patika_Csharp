using System;

class Memeli
{
    public double Boy;
    public double Agirlik;

    public Memeli(double boy, double agirlik)
    {
        this.Boy = boy;
        this.Agirlik = agirlik;
    }

    virtual public void Konus()
    {
        Console.WriteLine("Ben konusamam");
    }
}

class Kedi : Memeli
{
    public string Turu;

    public Kedi(string turu, int boy, int agirlik):base(boy,agirlik)
    {
        this.Turu = turu;
    }

    public override void Konus()
    {
        Console.WriteLine("ben kediyim");
    }
}

class Koyun : Memeli
{
    public string Turu;
    public Koyun(string turu, int boy, int agirlik):base(boy,agirlik)
    {
        this.Turu = turu;
    }

    public override void Konus()
    {
        Console.WriteLine("Ben koyunum");
    }
}

class MainMetodu
{
    static void Main()
    {
        Memeli memeli1 = new Memeli(10,20);
        Kedi kedi1 = new Kedi("van",30,40);
        Koyun koyun1 = new Koyun("ankara",50,60);

        memeli1 = kedi1;
        memeli1.Konus();

        memeli1 = koyun1;
        memeli1.Konus();
    }
}