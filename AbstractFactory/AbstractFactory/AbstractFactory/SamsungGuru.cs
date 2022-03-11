using AbstractFactory.Interface;

namespace AbstractFactory
{
    /// <summary>
    /// Produto b2
    /// </summary>
    public class SamsungGuru : INormalphone
    {
        public string BuscarDetalhesModelo() => "Modelo: Samsung GURU \n RAM: NA\nCamera: NA\n";
    }
}
