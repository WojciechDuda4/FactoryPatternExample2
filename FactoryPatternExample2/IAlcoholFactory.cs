using FactoryPatternExample2.Alcohols;

namespace FactoryPatternExample2
{
    public interface IAlcoholFactory
    {
        IAlcohol CreateVodka();

        IAlcohol CreateWhisky();

        IAlcohol CreateBeer();
    }
}
