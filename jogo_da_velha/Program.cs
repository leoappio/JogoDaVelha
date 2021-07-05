using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_velha
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            Computador computador = new Computador(jogo);

            while (!jogo.acabou)
            {
                Console.Clear();
                Console.WriteLine("Jogo da velha");
                Console.WriteLine("Você é X e o computador é O");
                Console.WriteLine("Boa sorte!");
                Tela.ImprimirTabuleiro(jogo);
                Console.WriteLine();
                Console.WriteLine("Digite uma posição para jogar [1-9]");
                int jogada = int.Parse(Console.ReadLine());

                if(jogo.realizarJogada(jogada, "X"))
                {
                    computador.realizarJogada();
                }


            }


            

            Console.ReadLine();
        }
    }
}
