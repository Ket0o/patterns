namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        VideoCard videoCard = new DiscreteGraphicsCard(new Amd());
        Console.WriteLine(videoCard.GetCost());
        
        videoCard.SetBrand(new Nvidia());
        Console.WriteLine(videoCard.GetCost());

        videoCard = new IntegratedGraphicsCard(new Amd());
        Console.WriteLine(videoCard.GetCost());
        
        videoCard.SetBrand(new Nvidia());
        Console.WriteLine(videoCard.GetCost());
        
        videoCard = new ProfessionalGraphicsCard(new Amd());
        Console.WriteLine(videoCard.GetCost());
        
        videoCard.SetBrand(new Nvidia());
        Console.WriteLine(videoCard.GetCost());
    }
}