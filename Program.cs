
using System.Linq.Expressions;

Console.Clear();
Console.WriteLine("Bem-Vindo!");
Console.WriteLine("Qual jogo gostaria de jogar hoje?");
Console.WriteLine("1- Para LOTERIA");
Console.WriteLine("2- Para ADIVINHAÇÃO");
int escolhaDoUsuario = int.Parse(Console.ReadLine());
bool verificar = true;

if (escolhaDoUsuario == 1)
{
    Console.Clear();
    Console.WriteLine($"Você Selecionou LOTERIA");
    int[] sorteioLoteria = new int[6];
    int[] numerosDoUsuario = new int[6];
    bool saidaDoProgramaCondicao = true;

    Random sorteioDosNumeros = new Random();
    for (int i = 0; i < sorteioLoteria.Length; i++)
    {
        sorteioLoteria[i] = sorteioDosNumeros.Next(1, 61);
        Console.WriteLine(sorteioLoteria[i]);
    }

    while (saidaDoProgramaCondicao)
    {
        Console.Clear();
        for (int i = 0; i < numerosDoUsuario.Length; i++)
        {
            Console.WriteLine("Digite um número");
            numerosDoUsuario[i] = int.Parse(Console.ReadLine());
        }

        if (sorteioLoteria.SequenceEqual(numerosDoUsuario))
        {
            Console.WriteLine("Você ganhou");
        }
        else
        {
            Console.WriteLine("Você perdeu!");
            Console.WriteLine("1- Para tentar novamente");
            Console.WriteLine("0 -Para Sair");
            int saidaDoprograma = int.Parse(Console.ReadLine());
            if (saidaDoprograma == 0)
            {
                saidaDoProgramaCondicao = false;

            }

        }
    }
}
if (escolhaDoUsuario == 2)
{
    Console.Clear();
    Console.WriteLine($"Você Selecionou ADIVINHAÇÃO");
    int[] numeroMaquina = new int[1];
    int[] numeroUsuario = new int[1];
    bool saidaDoProgramaCondicao = true;


    Random sorteio = new Random();
    for (int i = 0; i < numeroMaquina.Length; i++)
    {
        numeroMaquina[i] = sorteio.Next(1, 11);
    }


    while (saidaDoProgramaCondicao)
    {


        for (int i = 0; i < numeroUsuario.Length; i++)
        {
            Console.Clear() ;
            Console.WriteLine("Digite seu numero");
            numeroUsuario[i] = int.Parse(Console.ReadLine());
        }


        if (numeroMaquina.SequenceEqual(numeroUsuario))
        {
            Console.WriteLine("Você ganhou");
            saidaDoProgramaCondicao = false;

        }
        else
        {
            Console.Clear() ;
            Console.WriteLine("Você perdeu!");
            Console.WriteLine("1- Para tentar novamente");
            Console.WriteLine("0 -Para Sair");
            int saidaDoprograma = int.Parse(Console.ReadLine());
            if (saidaDoprograma == 0)
            {
                saidaDoProgramaCondicao = false;

            }
        }
    }
}




