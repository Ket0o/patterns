namespace test2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(MySqrt(x));
        }
        public static int MySqrt(int x)
        {
            if (x < 0 || x > Math.Pow(2, 31) - 1)
            {
                throw new ArgumentException($"0 <= x <= {Math.Pow(2, 31) - 1}");
            }
            else
            {
                double sqrt = 1;
                int step = 0;

                while ((int)(sqrt * sqrt) != x)
                {
                    sqrt = sqrt + Math.Abs(((Math.Pow(-1, step) * Fact(2*step)) / 
                            ((1 - 2*step)*Math.Pow(Fact(step), 2)*(Math.Pow(4, step)))) * 
                           Math.Pow(x, step));
                    step++;
                }

                return (int)sqrt;
            }
        }

        public static int Fact(int a)
        {
            if (a == 1) return 1;

            if(a == 0) return 0;

            return a * Fact(a - 1);
        }
    }
}
