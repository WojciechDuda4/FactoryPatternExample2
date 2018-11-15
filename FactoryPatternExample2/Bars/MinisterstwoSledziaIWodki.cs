using FactoryPatternExample2.Alcohols;

namespace FactoryPatternExample2.Bars
{
    public class MinisterstwoSledziaIWodki : IBar
    {
        IAlcoholFactory _alcoholFactory;

        public MinisterstwoSledziaIWodki(IAlcoholFactory alcoholFactory)
        {
            _alcoholFactory = alcoholFactory;
        }
        public string GetAlcoholWithVoltage()
        {
            IAlcohol alcohol = _alcoholFactory.CreateVodka();
            return string.Format("Dostałeś {0} mający {1}%", alcohol.Name, alcohol.Voltage);
        }

        public override string ToString()
        {
            return "MinisterstwoSledziaIWodki";
        }
    }
}
