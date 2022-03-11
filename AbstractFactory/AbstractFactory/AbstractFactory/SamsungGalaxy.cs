using AbstractFactory.Interface;

namespace AbstractFactory
{
    /// <summary>
    /// Produto a2
    /// </summary>
    public class SamsungGalaxy : ISmartphone
    {
        public string BuscarDetalhesModelo() => "Model: Samsung Galaxy\n RAM: 2GB \n Camera: 13MP\n";
    }
}
