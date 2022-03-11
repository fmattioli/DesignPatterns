using ObserverPattern;

EstacaoMetereologica estacaoMetereologica = new EstacaoMetereologica();
NovasAgenciasNoticias AgenciasNoticias = new NovasAgenciasNoticias("Agência de noticias de SP");
estacaoMetereologica.Anexar(AgenciasNoticias);

NovasAgenciasNoticias AgenciasNoticias2 = new NovasAgenciasNoticias("Agência de noticias de Suzano");
estacaoMetereologica.Anexar(AgenciasNoticias2);

estacaoMetereologica.Temperatura = 31.4f;
estacaoMetereologica.Temperatura = 25f;
estacaoMetereologica.Temperatura = 26.7f;
estacaoMetereologica.Temperatura = 34.7f;
estacaoMetereologica.Temperatura = 22f;
estacaoMetereologica.Temperatura = 15.7f;

Console.ReadLine();
