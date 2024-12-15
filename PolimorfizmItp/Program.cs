class Zwierze
{
    public virtual void DajGlos()
    {
        Console.WriteLine("Zwierze wydaje dzwiek");
    }
}

class Pies: Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Kot wydaje dzwiek");
    }
}

class Kot : Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Kot wydaje dzwiek");
    }
}

class Program
{
    Static void Main()
    {
        Zwierze zwierze = new Pies();
        Zwierze zwierze1 = new Kot();
        zwierze.DajGlos();
        zwierze1.DajGlos();
    }
}

