namespace Jewelry_Decorator;

public abstract class Pizza
{
    public string Name { get; }

    protected Pizza(string name)
    {
        Name = name;
    }

    public abstract long GetCost();
}

public class Pepperoni : Pizza
{
    public Pepperoni() : base("Пепперони")
    {
        
    }

    public override long GetCost()
    {
        return 1300;
    }
}

public class Margaret : Pizza
{
    public Margaret() : base("Маргарита")
    {
        
    }

    public override long GetCost()
    {
        return 1100;
    }
}

public abstract class PizzaDecorator : Pizza
{
    protected Pizza Pizza { get;}

    public PizzaDecorator(Pizza pizza, string name) : base(pizza.Name + name)
    {
        Pizza = pizza;
    }
}

public class CheeseDecorator : PizzaDecorator
{
    public CheeseDecorator(Pizza pizza) : base(pizza, " с сыром")
    {
        
    }

    public override long GetCost()
    {
        return Pizza.GetCost() + 100;
    }
}

public class TurkeyDecorator : PizzaDecorator
{
    public TurkeyDecorator(Pizza pizza) : base(pizza, " с индейкой")
    {
        
    }

    public override long GetCost()
    {
        return Pizza.GetCost() + 200;
    }
}