using FactoryPatternExample2.Alcohols;
using FactoryPatternExample2.Bars;
using System;

namespace FactoryPatternExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAlcoholFactory alcoholFactory = new AlcoholFactory();

            Console.WriteLine("Ziomeczki wbija�y kolejno do r�nych bar�w.");
            Console.WriteLine("\n");
            Console.WriteLine("Pierwszym barem by�: ");

            IBar bar = new AngielskaMordownia(alcoholFactory);

            Console.WriteLine(bar.ToString());

            Console.WriteLine("Zam�wi�e� alkohol.");
            Console.WriteLine(bar.GetAlcoholWithVoltage());

            Console.WriteLine("\n");
            Console.WriteLine("Drugim barem by�: ");

            IBar bar2 = new MinisterstwoSledziaIWodki(alcoholFactory);

            Console.WriteLine(bar2.ToString());

            Console.WriteLine("Zam�wi�e� alkohol.");
            Console.WriteLine(bar2.GetAlcoholWithVoltage());

            Console.WriteLine("\n");
            Console.WriteLine("Trzecim barem by�: ");

            IBar bar3 = new DobryZbeer(alcoholFactory);

            Console.WriteLine(bar3.ToString());

            Console.WriteLine("Zam�wi�e� alkohol.");
            Console.WriteLine(bar3.GetAlcoholWithVoltage());

            Console.ReadKey();
        }
    }
}
