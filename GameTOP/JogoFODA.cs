using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class jogoFODA
    {
        private readonly IJogador _jogador;

        public jogoFODA(IJogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            Console.Write(_jogador.Correr());
            Console.Write(_jogador.Chutar());
            Console.Write(_jogador.Passar());
        }
    }
}