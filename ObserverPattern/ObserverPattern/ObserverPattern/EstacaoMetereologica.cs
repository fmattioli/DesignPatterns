using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class EstacaoMetereologica : ISubject
    {
        private List<IObserver> observers;

        public float _Temperatura;
        public float Temperatura 
        {
            get 
            { 
                return _Temperatura; 
            } 
            set 
            { 
                _Temperatura = value; 
                Notificar(); 
            }
        }

        public EstacaoMetereologica()
        {
            this.observers = new List<IObserver>();
        }
        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notificar()
        {
            observers.ForEach(o =>
            {
                o.Atualizar(this);
            });
        }
    }
}
