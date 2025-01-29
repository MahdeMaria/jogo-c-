using System;
using System.Collections.Generic;

namespace UserApp
{
    class Program
    {
        string palavrachave = "cavalo";
    bool continuar = true;
    public void ExecutarJogo()
     {
        while (continuar)
        {
            Console.WriteLine("Bem-vindo(a) ao jogo da forca!");
            Console.WriteLine("DICA: A palavra secreta é um animal mamífero");
            Console.WriteLine("Digite uma letra");
            string letra = Console.ReadLine();

            int tentativas = 4;

            for (int i=0; i < tentativas; i++) 
            {
                string[] letrasCertas = { "-", "-", "-", "-", "-", "-" };
                  
                if (palavrachave.Contains(letra))
                {
                    Console.WriteLine("Parabéns! A letra está na palavra secreta");

                }
                else
                {
                    Console.WriteLine("Errou! Tente novamente");
                }
            }
                continuar = false;
        }
    }  
    }
}