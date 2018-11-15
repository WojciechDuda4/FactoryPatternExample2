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

            Console.WriteLine("Ziomeczki wbija³y kolejno do ró¿nych barów.");
            Console.WriteLine("\n");
            Console.WriteLine("Pierwszym barem by³: ");

            IBar bar = new AngielskaMordownia(alcoholFactory);

            Console.WriteLine(bar.ToString());

            Console.WriteLine("Zamówi³eœ alkohol.");
            Console.WriteLine(bar.GetAlcoholWithVoltage());

            Console.WriteLine("\n");
            Console.WriteLine("Drugim barem by³: ");

            IBar bar2 = new MinisterstwoSledziaIWodki(alcoholFactory);

            Console.WriteLine(bar2.ToString());

            Console.WriteLine("Zamówi³eœ alkohol.");
            Console.WriteLine(bar2.GetAlcoholWithVoltage());

            Console.WriteLine("\n");
            Console.WriteLine("Trzecim barem by³: ");

            IBar bar3 = new DobryZbeer(alcoholFactory);

            Console.WriteLine(bar3.ToString());

            Console.WriteLine("Zamówi³eœ alkohol.");
            Console.WriteLine(bar3.GetAlcoholWithVoltage());

            Console.ReadKey();
        }
    }
}
