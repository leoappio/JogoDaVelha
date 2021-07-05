using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_velha
{
    class Computador
    {
        private Jogo jogo;

        public Computador(Jogo jogo)
        {
            this.jogo = jogo;
        }

        public void realizarJogada()
        {
            int posicao = gerarPosicaoAleatoria();

            jogo.realizarJogada(posicao, "O");
        }

        private int gerarPosicaoAleatoria()
        {
            Random random = new Random();
            int posicao;
            while (true)
            {
                posicao = random.Next(1, 9);

                if (jogo.casaEstaVazia(posicao))
                {
                    return posicao;
    
                }
            }

        }
    }
}
