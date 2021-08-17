using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFODA(new Jogador("Cadu"));

            jogo.IniciarJogo();
        }
    }
}
