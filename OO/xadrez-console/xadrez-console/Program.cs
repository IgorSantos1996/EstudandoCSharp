using System;
using xadrez;
using tabuleiro;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8,8);
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 2));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 2));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 7));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroExcepetion e )
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
