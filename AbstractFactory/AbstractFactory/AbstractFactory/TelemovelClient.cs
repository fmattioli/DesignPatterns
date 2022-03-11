using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Cliente
    /// </summary>
    public class TelemovelClient
    {
        ISmartphone smartPhone;
        INormalphone normalPhone;
        public TelemovelClient(ITelemovel telemovelFactory)
        {
            smartPhone = telemovelFactory.BuscarSmartPhone();
            normalPhone = telemovelFactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone.BuscarDetalhesModelo();
        }
    }
}
