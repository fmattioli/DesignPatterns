﻿using ExampleDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDecoratorPattern
{
    //Base Decorator
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza) => _pizza = pizza;

        public virtual string BuscarTipoPizza()
        {
            return _pizza.BuscarTipoPizza();
        }

        
    }
}
