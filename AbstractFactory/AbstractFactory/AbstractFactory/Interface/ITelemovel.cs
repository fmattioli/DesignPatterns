namespace AbstractFactory.Interface
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface ITelemovel
    {
        ISmartphone BuscarSmartPhone();
        INormalphone BuscarNormalPhone();
    }
}
