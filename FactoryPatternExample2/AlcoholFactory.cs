using FactoryPatternExample2.Alcohols;

namespace FactoryPatternExample2
{
    public class AlcoholFactory : IAlcoholFactory
    {
        public IAlcohol CreateBeer() => new Beer();

        public IAlcohol CreateVodka() => new Vodka();

        public IAlcohol CreateWhisky() => new Whisky();
    }
}
