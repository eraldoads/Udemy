using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contrutor jogar que receve um Jogador
            var jogo = new JogoFODA(
                new Jogador1(),
                new Jogador3()
            );

            jogo.IniciarJogo();
        }
    }
}
