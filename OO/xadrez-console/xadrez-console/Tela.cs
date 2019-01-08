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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabi.colunas; j++)
                {
                    if (tabi.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tabi.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
