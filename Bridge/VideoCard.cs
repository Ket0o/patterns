namespace Bridge;

public abstract class VideoCard
{
    private Brand _brand;
    private readonly long _cost;

    protected VideoCard(Brand brand, long cost)
    {
        _brand = brand;
        _cost = cost;
    }

    public virtual long GetCost()
    {
        return _cost * _brand.ExtraCharge;
    }

    public void SetBrand(Brand brand)
    {
        _brand = brand;
    }
}

public abstract class Brand
{
    public int ExtraCharge { get; protected init; }
}

public class Nvidia : Brand
{
    public Nvidia()
    {
        ExtraCharge = 6;
    }
}

public class Amd : Brand
{
    public Amd()
    {
        ExtraCharge = 3;
    }
}

public class Intel : Brand
{
    public Intel()
    {
        ExtraCharge = 2;
    }
}

public class IntegratedGraphicsCard : VideoCard
{
    public IntegratedGraphicsCard(Brand brand) : base(brand, 100)
    {
    }
}

public class DiscreteGraphicsCard : VideoCard
{
    public DiscreteGraphicsCard(Brand brand) : base(brand, 200)
    {
    }
}

public class ProfessionalGraphicsCard : VideoCard
{
    public ProfessionalGraphicsCard(Brand brand) : base(brand, 300)
    {
    }
}