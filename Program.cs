using DesafioPOO.Models;
using DesafioPOO.Utils;

List<Smartphone> smartphones = new()
{
    new Nokia("123456789", "X30", "351756051523999", 128),
    new Nokia("987654321", "G60", "358240051111222", 128),
    new Nokia("985746321", "XR21", "356789104567890", 256),
    new Iphone("985741236", "13", "353915112223334", 128),
    new Iphone("123789456", "14 Pro", "359876543210123", 256),
    new Iphone("321654987", "15", "352099001122334", 512)
};

Console.WriteLine("=== Stand de Smartphones DIO ===\n");

bool continuar = true;

while (continuar)
{

    for (int i = 0; i < smartphones.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {smartphones[i]}\n");
    }

    int numeroSmartphoneEscolhido = ProgramUtils.LerEscolhaDeSmartphone("Escolha um smartphone para testar:", 1, smartphones.Count);

    Smartphone smartphoneSelecionado = smartphones[numeroSmartphoneEscolhido - 1];
    Console.WriteLine();

    smartphoneSelecionado.Ligar();
    smartphoneSelecionado.ReceberLigacao();
    string nomeApp = ProgramUtils.LerNomeDeAplicativo();
    Console.WriteLine();
    smartphoneSelecionado.InstalarAplicativo(nomeApp);

    continuar = ProgramUtils.LerRespostaSimNao("\nDeseja testar outro smartphone? (S/N)");
}

Console.WriteLine("\nObrigado por visitar o Stand de Smartphones DIO!");