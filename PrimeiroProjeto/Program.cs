//Screen Sound
using System;

String mensagemDeBoasVindas = " Boas vindas ao Screen Sound";
//List<String> listaDasBandas = new List<String> { "system of a down","slipknot", "u2"};
Dictionary<string, List<int>>bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("linkPark", new List<int> { 10,9,8});
bandasRegistradas.Add("System of a down", new List<int> ());

void ExibirLogo() {

    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(mensagemDeBoasVindas);
   
}
 void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para resgistar uma banda ");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1 :
            RegistrarBanda();

            break;
        case 2:
           ExibirBandas();

            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :) ");
            break;
            default: Console.WriteLine("opção inválida");
            break;

    }

    }


void RegistrarBanda() {

    Console.Clear();
    ExibirTituloDaOpcao("registro de bandas");
    Console.Write("digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi Registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear() ;
    ExibirOpcoesDoMenu();


}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas.");

    foreach (String banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"banda: {banda}");
    }
   
    Console.WriteLine("\ndigite uma tecla para voltar o menu princial!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarBanda()
{

    //digite qual banda deseja avaliar
    //se a banda existe no dicionario >> atribuir uma nota 
    //senão volta ao menu principal 

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para banda {nomeDaBanda}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {

        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("digite uma tecla para voltar ao menu inicial!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
    void MediaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Media da Banda");
        Console.Write("Qual o nome da banda que deseja ver a media: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA media da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
            Console.WriteLine("Digite uma tecla para voltar ao menu inicial!");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada");
            Console.WriteLine("digite uma tecla para voltar ao menu inicial!");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

    }


ExibirOpcoesDoMenu();