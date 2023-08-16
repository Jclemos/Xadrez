using Tabuleiro;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

            Tela.ImprimirTabuleiro(tab);


        }
    }
}