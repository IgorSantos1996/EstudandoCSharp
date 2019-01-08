using System;
using tabuleiro;
namespace xadrez_console.tabuleiro
{

    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabi)
        {
            for (int i = 0; i < tabi.linhas; i++)
            {
                for (int j = 0; j < tabi.colunas; j++)
                {
                    if (tabi.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabi.peca(i, j) + "");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
