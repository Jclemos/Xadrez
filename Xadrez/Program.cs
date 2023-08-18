using tabuleiro;
using xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preto, tab), new Posicao(0,0));
                tab.colocarPeca(new Torre(Cor.Preto, tab), new Posicao(1,3));
                tab.colocarPeca(new Rei(Cor.Preto, tab), new Posicao(0,3));

                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(0,2));

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}