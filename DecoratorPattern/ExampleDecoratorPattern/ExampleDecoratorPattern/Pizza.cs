using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            return "Está é uma pizza normal";
        }
    }
}
