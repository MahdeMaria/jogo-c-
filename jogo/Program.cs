using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] palavras = { "programacao", "desenvolvimento", "computador", "teclado", "software" };
        Random random = new Random();
        string palavraSecreta = palavras[random.Next(palavras.Length)];
        char[] palavraOculta = new string('_', palavraSecreta.Length).ToCharArray();
        List<char> tentativas = new List<char>();
        int tentativasRestantes = 6;
        
        while (tentativasRestantes > 0 && new string(palavraOculta) != palavraSecreta)
        {
            Console.Clear();
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("Palavra: " + new string(palavraOculta));
            Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
            Console.WriteLine("Letras tentadas: " + string.Join(", ", tentativas));
            Console.Write("Digite uma letra: ");
            char tentativa = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (tentativas.Contains(tentativa))
            {
                Console.WriteLine("Você já tentou essa letra!");
                Console.ReadKey();
                continue;
            }

            tentativas.Add(tentativa);

            if (palavraSecreta.Contains(tentativa))
            {
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == tentativa)
                    {
                        palavraOculta[i] = tentativa;
                    }
                }
            }
            else
            {
                tentativasRestantes--;
            }
        }

        Console.Clear();
        if (new string(palavraOculta) == palavraSecreta)
        {
            Console.WriteLine("Parabéns! Você acertou a palavra: " + palavraSecreta);
        }
        else
        {
            Console.WriteLine("Fim de jogo! A palavra era: " + palavraSecreta);
        }
    }
}
