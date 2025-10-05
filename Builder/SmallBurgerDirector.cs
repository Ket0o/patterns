namespace Builder
{
    public class SmallBurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public SmallBurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.WithCheese();

            _builder.WithTomato();
        }
    }
}
