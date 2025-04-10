﻿namespace DiamanteX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            while (repetir)
            {
                #region Entrada e Validação
                int numero = ObterNumeroImpar();
                #endregion

                #region Geração do Diamante
                DesenharDiamante(numero);
                #endregion

                #region Pergunta para repetir
                Console.Write("\nDeseja executar novamente? (s/n): ");
                string resposta = Console.ReadLine();

                repetir = resposta.Trim().ToLower() == "s";
                Console.WriteLine();
                #endregion
            }

            Console.WriteLine("Encerrando o programa. Até logo!");
        }

        #region Função: Obter número ímpar válido
        static int ObterNumeroImpar()
        {
            int numero;

            while (true)
            {
                Console.Write("Digite um número ímpar: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero) && numero % 2 != 0)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro ímpar.");
                }
            }
        }
        #endregion

        #region Função: Desenhar diamante
        static void DesenharDiamante(int tamanho)
        {
            int meio = tamanho / 2;

            // Parte superior (inclui linha do meio)
            for (int i = 0; i <= meio; i++)
            {
                ImprimirLinha(tamanho, i);
            }

            // Parte inferior
            for (int i = meio - 1; i >= 0; i--)
            {
                ImprimirLinha(tamanho, i);
            }
        }
        #endregion

        #region Função: Imprimir linha do diamante
        static void ImprimirLinha(int tamanho, int linhaAtual)
        {
            int qtdEspacos = (tamanho / 2) - linhaAtual;
            int qtdXs = linhaAtual * 2 + 1;

            Console.Write(new string(' ', qtdEspacos));
            Console.WriteLine(new string('X', qtdXs));
        }
        #endregion
    }
}