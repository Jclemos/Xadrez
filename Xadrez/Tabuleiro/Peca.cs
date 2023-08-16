namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; set; }
        public TabuleiroXadrez Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroXadrez tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimento = 0;
        }
    }
}
