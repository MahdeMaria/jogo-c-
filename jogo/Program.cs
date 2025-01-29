using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Program jogo = new Program();
        jogo.ExecutarJogo();
    }

    public void ExecutarJogo()
    {
        char[] palavraChave = {'c','a','v','a','l','o'};
        char[] palavraOculta = new string('_', palavraChave.Length).ToCharArray();
        bool continuar = true;
        int tentativas = 0;

        Console.WriteLine("Bem-vindo(a) ao jogo da forca!");
        Console.WriteLine("DICA: A palavra secreta é um animal mamífero");

        while (continuar)
        {
            Console.WriteLine("Palavra: " + new string(palavraOculta));
            Console.WriteLine("Digite uma letra:");
            char letra = Console.ReadLine()?.FirstOrDefault() ?? ' ';;
            Console.WriteLine("\nPalavra: " + new string(palavraOculta));

            if (palavraChave.Contains(letra))
            {
                Console.WriteLine("Parabéns! A letra está na palavra secreta");
                for (int i = 0; i < palavraChave.Length; i++)
                {
                    if (palavraChave[i] == letra)
                    {
                        palavraOculta[i] = letra;
                    }
                }
            }
            else
            {
                Console.WriteLine("Errou! Tente novamente");
            }

            tentativas++;

            if (tentativas >= 10)
            {
                Console.WriteLine("Ops! Parece que acabaram suas tentativas.");
                continuar = false;
            }
        }
    }
}
