// Screen Sound
using System.Net.Http.Headers;
using System.Security.AccessControl;

string mensagem = "boas vindas";
//ist<string> ListaDeBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("link park", new List<int> { 10, 8, 3 });
bandasRegistradas.Add("the beatles", new List<int>());

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("****************");
    Console.WriteLine(mensagem);
    Console.WriteLine("****************");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("digite 1 para registrar uma banda");
    Console.WriteLine("digite 2 para mostrar todas as bandas");
    Console.WriteLine("digite 3 para avaliar uma banda");
    Console.WriteLine("digite 4 para exibir a media de uma banda");
    Console.WriteLine("digite 0 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case 0:
            Console.WriteLine("sair");
            break;
        default:
            Console.WriteLine("opção invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"a banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************");
    /*for (int i = 0; i < ListaDeBandas.Count; i++){
        Console.WriteLine($"Banda: {ListaDeBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"banda: {banda}");
    }
    Console.WriteLine("Digite umaa tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    //digitar qual banda deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota
    // senao, voltar ao menu principal
    Console.Clear();
    Console.WriteLine("Avaliar uma banda");
    Console.Write("digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"qual nome que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\na nota {nota} foi registrada com sucesso para a banda {nomeDaBanda} ");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"a banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDaBanda(){
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("media de nota da banda");
    Console.WriteLine("**********************");
    Console.Write("digite o nome da banda que deseja obter a media das notas: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDabanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA media da bnda {nomeDaBanda} é {notasDabanda.Average()}");
        Console.WriteLine("digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"a banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();