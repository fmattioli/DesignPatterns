using AbstractFactory.Interface;

namespace AbstractFactory
{
    /// <summary>
    /// Produto A1
    /// </summary>
    public class NokiaPixel : ISmartphone
    {
        public string BuscarDetalhesModelo() => "Model: Nokia Pixel\n RAM: 3GB\n Camera: 8MP\n";
    }
}
