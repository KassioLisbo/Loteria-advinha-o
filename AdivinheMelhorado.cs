using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{

    static void Main()
    {

        //Menu
        Console.WriteLine("Bem vindo");
        Console.WriteLine("Gostaria de jogar nosso jogo?");
        Console.WriteLine("1- Sim");
        Console.WriteLine("2 - Não");
        int valorEscolhido = int.Parse(Console.ReadLine());
        if (valorEscolhido == 1)
        {
            AdivinheNumero();
        }
        else if(valorEscolhido == 2){
            AdivinheONao();
        }
    }

    static void AdivinheNumero()
    {
        int saldo = 2;
        
        int[] numeroGeradoPelaMaquina = new int[2];
        int[] numeroGeradoPeloPlayer = new int[2];
        bool jogandoAdivinhe = true;

        Console.Clear();
        Console.WriteLine($"Seu saldo é de R${saldo} ");
        Console.WriteLine();

        while (jogandoAdivinhe)
        {
            Random numeroDoSorteio = new Random();
            for (int i = 0; i < numeroGeradoPelaMaquina.Length; i++)
            {
                numeroGeradoPelaMaquina[i] = numeroDoSorteio.Next(1, 11);
                Console.WriteLine($"{numeroGeradoPelaMaquina[i]}");
            }

            for (int i = 0; i < numeroGeradoPeloPlayer.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número:");
                numeroGeradoPeloPlayer[i] = int.Parse(Console.ReadLine());
            }

            if (numeroGeradoPelaMaquina.SequenceEqual(numeroGeradoPeloPlayer))
            {
                saldo = Saldo(saldo + 2);
                Console.WriteLine("Parabéns você ganhou!!");
                Console.WriteLine($"Seu saldo agora é de R$ {saldo}");
                jogandoAdivinhe = JogarDeNovo();

            }
            else 
            {
                saldo = Saldo(saldo);
                Console.WriteLine("Você perdeu");
                Console.WriteLine($"Seu saldo é de {saldo}");
                jogandoAdivinhe = JogarDeNovo();
                

            }

            if (saldo <= 0)
            {
                Console.WriteLine("Seu saldo acabou");
                break;
            }

        }

    }
    static bool JogarDeNovo()
    {


        Console.WriteLine("Gostaria de jogar de novo?");
        Console.WriteLine("1- Para Jogar");
        Console.WriteLine("0 - Para Sair");
        int continuarJogo = int.Parse(Console.ReadLine());
        if (continuarJogo == 1)
        {
            Console.Clear();
            return true;
        }
        else 
        {
            Console.WriteLine("Adeus!");
            return false;  
        }


    }

    static void AdivinheONao()
    {
        Console.WriteLine("Que pena!");
        Console.WriteLine("F");
    }


    // Mexer na mecanica de saldo

    static int Saldo(int saldo)
    {
        return saldo -1 ;
    }

}
