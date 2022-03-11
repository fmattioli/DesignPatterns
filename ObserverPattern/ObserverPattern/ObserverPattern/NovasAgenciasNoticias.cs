using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern
{
    public class NovasAgenciasNoticias : IObserver
    {
        public string NomeAgencia { get; set; }

        public NovasAgenciasNoticias(string NomeAgencia) => this.NomeAgencia = NomeAgencia;
        public void Atualizar(ISubject subject)
        {
            if (subject is EstacaoMetereologica estacaoMetereologica)
            {
                Console.WriteLine(string.Format("{0} reportando a temperatura {1} graus celsius", NomeAgencia, estacaoMetereologica.Temperatura));
            }
            Console.WriteLine();
        }
    }
}
