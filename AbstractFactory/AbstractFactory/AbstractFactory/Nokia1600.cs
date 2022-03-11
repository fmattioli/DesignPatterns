using AbstractFactory.Interface;

namespace AbstractFactory
{
    /// <summary>
    /// Produto B1
    /// </summary>
    public class Nokia1600 : INormalphone
    {
        public string BuscarDetalhesModelo() => "Model: Nokia 1600 \n RAM: NA \nCamera: NA \n";
        
    }
}
