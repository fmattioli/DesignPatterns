using AbstractFactory;
using AbstractFactory.ConcretesFactory;
using AbstractFactory.Interface;

ITelemovel nokiaTelemovel = new Nokia();
TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);
Console.WriteLine("********** NOKIA **********");
Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDetalhes());


ITelemovel samsung = new Samsung();
TelemovelClient samsungClient = new TelemovelClient(samsung);
Console.WriteLine("********** SAMSUNG **********");
Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
Console.WriteLine(samsungClient.BuscarNormalPhoneModeloDetalhes());


Console.ReadKey();
