﻿using FactoryPatternExample2.Alcohols;

namespace FactoryPatternExample2.Bars
{
    public class AngielskaMordownia : IBar
    {
        IAlcoholFactory _alcoholFactory;

        public AngielskaMordownia(IAlcoholFactory alcoholFactory)
        {
            _alcoholFactory = alcoholFactory;
        }
        public string GetAlcoholWithVoltage()
        {
            IAlcohol alcohol = _alcoholFactory.CreateWhisky();
            return string.Format("Dostałeś {0} mający {1}%", alcohol.Name, alcohol.Voltage);
        }

        public override string ToString()
        {
            return "AngielskaMordownia";
        }
    }
}
