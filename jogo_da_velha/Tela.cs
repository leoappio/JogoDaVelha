using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_velha
{
    class Tela
    {
        public static void ImprimirTabuleiro(Jogo jogo)
        {
            string[,] pecas = jogo.pecas;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    if(pecas[i,j] != null)
                    {
                        Console.Write(pecas[i,j]+" ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                
            }
            Console.WriteLine("");
        }
    }
}
