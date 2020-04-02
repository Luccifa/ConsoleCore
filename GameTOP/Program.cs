using System;
using GameTOP.lib;
using GameTOP.Interface;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var jogo = new JogoFODA(
                new Jogador1("Ronaldo"),
                new Jogador2(),
                new Jogador3()
                );
            
            jogo.IniciarJogo();
        }
    }

  

}