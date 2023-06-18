using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            AtributoJogador jogador1 = CriarJogador();
            AtributoJogador jogador2 = CriarJogador();

            int valor = randNum.Next(1, 3);

            Console.WriteLine("O jogo será iniciado por: " + (valor == 1 ? jogador1.Nome : jogador2.Nome));

            Jogar(jogador1, jogador2, valor);
        }

        static AtributoJogador CriarJogador()
        {
            AtributoJogador jogador = new AtributoJogador();

            Console.WriteLine("Entre com o nome do jogador:");
            jogador.Nome = Console.ReadLine();

            jogador.Energias = 10;

            return jogador;
        }

        static void Jogar(AtributoJogador jogador1, AtributoJogador jogador2, int valor)
        {
            Random randNum = new Random();

            int contJ1 = 0;
            int contJ2 = 0;

            while (jogador1.Energias > 0 && jogador2.Energias > 0)
            {
                AtributoJogador jogadorAtual = (valor == 1 ? jogador1 : jogador2);

                Console.WriteLine(jogadorAtual.Nome + " aperte enter para receber suas cartas");
                Console.ReadLine();

                int valor1 = randNum.Next(10, 13);
                int valor2 = randNum.Next(10, 13);
                int valor3 = randNum.Next(10, 13);

                Console.WriteLine(valor1);
                Console.WriteLine(valor2);
                Console.WriteLine(valor3);

                if (valor1 != valor2 || valor1 != valor3 || valor2 != valor3)
                {
                    jogadorAtual.Energias -= 1;
                    Console.WriteLine("Como suas cartas foram diferentes você perdeu 1 energia");
                    Console.WriteLine("Te restam: " + jogadorAtual.Energias + " energias");
                }
                else
                {
                    Console.WriteLine("Como suas cartas foram iguais, " + jogadorAtual.Nome + " continua com " + jogadorAtual.Energias + " energias");
                }

                if (jogadorAtual == jogador1)
                    contJ1++;
                else
                    contJ2++;

                valor = (valor == 1 ? 2 : 1);
            }

            Console.WriteLine("Fim do jogo");
        }
    }

    class AtributoJogador
    {
        public int id;
        public string Nome;
        public int Energias;
    }
}
