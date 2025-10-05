namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, ITimeZoneStrategy> timeZoneStrategies = new()
        {
            {"1", new TomskTimeZoneStrategy()},
            {"2", new MoscowTimeZoneStrategy()},
        };
        
        while (true)
        {
            Console.WriteLine("Томск --> 1");
            Console.WriteLine("Москва --> 2");
            Console.WriteLine("Exit --> any button");

            var figureType = Console.ReadLine();
            
            if (figureType == null)
                continue;

            try
            {
                var timeZoneStrategy = timeZoneStrategies[figureType];
                timeZoneStrategy.PrintCityAndTimeInCity();
            }
            catch
            {
                break;
            }
        }
    }
}

public interface ITimeZoneStrategy
{
    public int HoursDifferenceWithUtc { get; }

    void PrintCityAndTimeInCity();
}

public class MoscowTimeZoneStrategy : ITimeZoneStrategy
{
    public int HoursDifferenceWithUtc { get; } = 3;
    
    public void PrintCityAndTimeInCity() 
        => Console.WriteLine($"Москва. Время: {DateTime.UtcNow.AddHours(HoursDifferenceWithUtc)}");
}

public class TomskTimeZoneStrategy : ITimeZoneStrategy
{
    public int HoursDifferenceWithUtc { get; } = 7;
    
    public void PrintCityAndTimeInCity() 
        => Console.WriteLine($"Томск. Время: {DateTime.UtcNow.AddHours(HoursDifferenceWithUtc)}");
}