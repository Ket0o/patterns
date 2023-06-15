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
        Jewelry necklaceWithDiamond = new Necklace();
        necklaceWithDiamond = new DiamondJewelry(necklaceWithDiamond);

        Jewelry necklaceWithTapaz = new Necklace();
        necklaceWithTapaz = new TapazJewelry(necklaceWithTapaz);

        Jewelry bracelet = new Bracelet();
        bracelet = new DiamondJewelry(bracelet);
        bracelet = new TapazJewelry(bracelet);

        Jewelry necklacetWithRubin = new Necklace();
        necklacetWithRubin = new RubinJewelry(necklacetWithRubin);
        necklacetWithRubin = new TapazJewelry(necklacetWithRubin);



        Console.WriteLine(necklaceWithDiamond.Name);
        Console.WriteLine(necklaceWithDiamond.GetCost());

        Console.WriteLine();

        Console.WriteLine(necklaceWithTapaz.Name);
        Console.WriteLine(necklaceWithTapaz.GetCost());

        Console.WriteLine();

        Console.WriteLine(bracelet.Name);
        Console.WriteLine(bracelet.GetCost());

        Console.WriteLine();

        Console.WriteLine(necklacetWithRubin.Name);
        Console.WriteLine(necklacetWithRubin.GetCost());
    }
}