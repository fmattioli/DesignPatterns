using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcretesFactory
{
    /// <summary>
    /// ConcreFactory1
    /// </summary>
    public class Nokia : ITelemovel
    {
        public INormalphone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartphone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
