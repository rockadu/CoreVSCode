using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : IJogador
    {
        public string Nome { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public string Chutar()
        {
            return $"{Nome} está chutando \n";
        }

        public string Correr()
        {
            return $"{Nome} está correndo \n";
        }

        public string Passar()
        {
            return $"{Nome} está passando \n";
        }
    }
}