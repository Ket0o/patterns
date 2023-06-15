using System.Net.Http.Headers;
using BurgerBuilderExample;

var burgerBuilder = new BurgerBuilder();

var smallBurgerDirector = new SmallBurgerDirector(burgerBuilder);

smallBurgerDirector.Build();

var smallBurger = burgerBuilder.GetBurger();

var largeBurgerDirector = new LargeBurgerDirector(burgerBuilder);

largeBurgerDirector.Build();

var largeBurger = burgerBuilder.GetBurger();


PrintBurgerCheck(smallBurger);
Console.WriteLine();
PrintBurgerCheck(largeBurger);
Console.WriteLine();
PrintBurgerCheck(new Burger());

void PrintBurgerCheck(Burger burger)
{
    if (burger.Bacon && burger.Cheese && burger.Tomato)
    {
        Console.WriteLine("Бургер с сыром, беконом и томатами");
    }
    else
    {
        if (burger.Bacon && burger.Cheese)
        {
            Console.WriteLine("Бургер с сыром и беконом");
        }
        else
        {
            if (burger.Tomato && burger.Cheese)
            {
                Console.WriteLine("Бургер с сыром и томатами");
            }
            else
            {
                if (burger.Tomato && burger.Bacon)
                {
                    Console.WriteLine("Бургер с беконом и томатами");
                }
                else
                {
                    Console.WriteLine("пустой бургер(");
                }
            }
        }
    }
}