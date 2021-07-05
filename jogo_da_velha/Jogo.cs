using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_velha
{
    class Jogo
    {
        public string[,] pecas { get; private set; }
        private string usuario;
        private string computador;
        public string vencedor { get; private set; }
        public bool acabou { get; private set; }

        public Jogo()
        {
            this.pecas = new string[3, 3];
            this.usuario = "X";
            this.computador = "O";
            this.acabou = false;
        }

        public bool realizarJogada(int numero, string jogador)
        {
            if (casaEstaVazia(numero))
            {
                string posicao = casaParaPosicao(numero);

                int linha = int.Parse(posicao[0] + "");
                int coluna = int.Parse(posicao[1] + "");

                colocarPeca(linha, coluna, jogador);

                return true;
            }

            return false;
        }

        public bool casaEstaVazia(int numero)
        {
            string posicao = casaParaPosicao(numero);

            if(posicao != null)
            {
                int linha = int.Parse(posicao[0] + "");
                int coluna = int.Parse(posicao[1] + "");

                if (pecas[linha, coluna] == null)
                {
                    return true;
                }
            }

            return false;
        }

        private void colocarPeca(int linha, int coluna, string jogador)
        {
            pecas[linha, coluna] = jogador;
        }
        

        private string casaParaPosicao(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "00";
                case 2:
                    return "01";
                case 3:
                    return "02";
                case 4:
                    return "10";
                case 5:
                    return "11";
                case 6:
                    return "12";
                case 7:
                    return "20";
                case 8:
                    return "21";
                case 9:
                    return "22";
                default:
                    return null;

            }
            
        }

        public void verificarVitoria()
        {
            if (verificarLinhas() || verificarColunas())
            {
                acabou = true;
            }
        }


        private bool verificarLinhas()
        {
            string casaAnterior;
            //verifica as linhas 
            for (int linha = 0; linha < 3; linha++)
            {
                casaAnterior = pecas[linha, 0];

                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (pecas[linha, coluna] != casaAnterior || pecas[linha, coluna] == null)
                    {
                        break;
                    }
                    else
                    {
                        if (coluna == 2)
                        {
                            vencedor = casaAnterior;
                            Console.WriteLine("vencedor linha");
                            return true;
                        
                        }
                    }
                }
            }

            return false;
        }

        private bool verificarColunas()
        {
            string casaAnterior;
            //verifica as linhas 
            for (int coluna = 0; coluna < 3; coluna++)
            {
                casaAnterior = pecas[0, coluna];

                for (int linha = 0; linha < 3; linha++)
                {
                    if (pecas[linha, coluna] != casaAnterior || pecas[linha, coluna] == null)
                    {
                        break;
                    }
                    else
                    {
                        if (linha == 2)
                        {
                            vencedor = casaAnterior;
                            Console.WriteLine("vencedor coluna");
                            return true;

                        }
                    }
                }
            }

            return false;
        }
    }
}
