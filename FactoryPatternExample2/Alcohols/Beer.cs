using System;

namespace FactoryPatternExample2.Alcohols
{
    public class Beer : IAlcohol
    {
        public string Name => "Piwo";

        public int Voltage => 6;
    }
}
