namespace Jewelry_Decorator;

abstract class Jewelry
{
    public string Name { get; set; }

    public Jewelry(string name)
    {
        Name = name;
    }

    public abstract int GetCost();
}

class Necklace : Jewelry
{
    public Necklace() : base("ожерелье") { }

    public override int GetCost()
    {
        return 1200;
    }
}

class Bracelet : Jewelry
{
    public Bracelet() : base("браслет") { }

    public override int GetCost()
    {
        return 1500;
    }
}

abstract class JewelryDecorator : Jewelry
{
    public Jewelry jewelry;

    public JewelryDecorator(string name, Jewelry jewelry) : base(name)
    {
        this.jewelry = jewelry;
    }
}

class DiamondJewelry : JewelryDecorator
{
    public DiamondJewelry(Jewelry jewelry) : base(jewelry.Name + " с бриллиантами", jewelry) { }

    public override int GetCost()
    {
        return jewelry.GetCost() + 5000;
    }
}

class TapazJewelry : JewelryDecorator
{
    public TapazJewelry(Jewelry jewelry) : base(jewelry.Name + " с тапазом", jewelry) { }

    public override int GetCost()
    {
        return jewelry.GetCost() + 1000;
    }
}

class RubinJewelry : JewelryDecorator
{
    public RubinJewelry(Jewelry jewelry) : base(jewelry.Name + " с рубин", jewelry) { }

    public override int GetCost()
    {
        return jewelry.GetCost() + 20000;
    }
}

class Program
{
    static void Main()
    {
        Pizza margaret = new Margaret();
        Console.WriteLine(margaret.Name + " " + margaret.GetCost());
        Console.WriteLine();

        margaret = new CheeseDecorator(margaret);
        Console.WriteLine(margaret.Name + " " + margaret.GetCost());
        Console.WriteLine();

        margaret = new TurkeyDecorator(margaret);
        Console.WriteLine(margaret.Name + " " + margaret.GetCost());
        Console.WriteLine();
    }
}