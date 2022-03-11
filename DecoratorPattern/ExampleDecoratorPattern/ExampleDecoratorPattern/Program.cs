using ExampleDecoratorPattern;
using ExampleDecoratorPattern.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IPizza pizza = new Pizza();
        IPizza queijoDecorator = new QueijoDecorator(pizza);
        IPizza banconDecorator = new BaconDecorator(queijoDecorator);
        IPizza CebolaDecorator = new CebolaDecorator(banconDecorator);
        Console.WriteLine(CebolaDecorator.BuscarTipoPizza());
        Console.ReadKey();
    }
}