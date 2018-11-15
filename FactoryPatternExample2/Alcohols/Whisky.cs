using System;

namespace FactoryPatternExample2.Alcohols
{
    public class Whisky : IAlcohol
    {
        public string Name => "Whisky";

        public int Voltage => 40;
    }
}
