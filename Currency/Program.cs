namespace Adapter
{
    interface ICurrency
    {
        float GetCourse();

        void ViewingCourse();
    }

    class RussianCurrency: ICurrency
    {
        float _currentCourse;

        public RussianCurrency(float course)
        {
            _currentCourse = course;
        }

        public float GetCourse()
        {
            return _currentCourse;
        }

        public void ViewingCourse()
        {
            Console.WriteLine("Просмотр курса рубля на данный момент");
        }
    }

    class USACurrency
    {
        float _currentCourse;

        public USACurrency(float course)
        {
            _currentCourse = course;
        }

        public float GetCourseUSA()
        {
            return _currentCourse;
        }

        public void ViewingCourseUSA()
        {
            Console.Write("Просмотр курса доллара на данный момент");
        }
    }

    class AdapterUSACurrency: USACurrency, ICurrency
    {
        public AdapterUSACurrency(float _currentCourse) : base(_currentCourse)
        {

        }

        float ICurrency.GetCourse()
        {
            return base.GetCourseUSA() * 77;
        }

        void ICurrency.ViewingCourse()
        {
            base.ViewingCourseUSA();
            Console.Write(" в рублях");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICurrency russianCurrency = new RussianCurrency(77);
            ICurrency usaCurrency = new AdapterUSACurrency(1);

            Console.WriteLine(russianCurrency.GetCourse());
            Console.WriteLine(usaCurrency.GetCourse());

            russianCurrency.ViewingCourse();
            Console.WriteLine();
            usaCurrency.ViewingCourse();
        }
    }
}