using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de Cebola!";
            return pizza;
        }
    }
}
