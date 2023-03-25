using System;

class Program
{
    static void Main(string[] args)
    {
        C c1nesne = new C(3,4,5);
        Console.WriteLine("** C nesnesi **");
        Console.WriteLine("a=" +c1nesne.a);
        Console.WriteLine("b=" +c1nesne.b);
        Console.WriteLine("c=" +c1nesne.c);

        B b1nesne = new B(6,7);
        Console.WriteLine("** B nesnesi **");
        Console.WriteLine("a=" +b1nesne.a);
        Console.WriteLine("b=" +b1nesne.b);

        A a1nesne = new A(8);
        Console.WriteLine("** A nesnesi **");
        Console.WriteLine("a=" +a1nesne.a);
        


    }
}

class A
{
    public int a;
    public A(int a)
    {
        this.a = a;
        Console.WriteLine("A sinifinin yapici metodu");
    }
}

class B : A
{
    public int b;
    public B(int a, int b) : base(a)
    {
        this.b=b;
        Console.WriteLine("B sinifinin yapici metodu");
    }
}

class C : B
{
    public int c;
    public C(int a, int b, int c) : base(a,b)
    {
        this.c=c;
        Console.WriteLine("C sinifinin yapici metodu");
    }
}