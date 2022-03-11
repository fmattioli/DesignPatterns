using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcretesFactory
{
    /// <summary>
    /// ConcreteFactory2
    /// </summary>
    public class Samsung : ITelemovel
    {
        public INormalphone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartphone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
