

using GameTOP.Interface;

namespace GameTOP
{
   
    class JogoFODA {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        private readonly IJogador _jogadorC;

        public JogoFODA(IJogador jogadorA, IJogador jogadorB, IJogador jogadorC) {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
        }
        public void IniciarJogo() {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());

            System.Console.Write("\n PROXIMO JOGADOR\n");
            
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());

            System.Console.Write("\n PROXIMO JOGADOR\n");
            
            System.Console.Write(_jogadorC.Corre());
            System.Console.Write(_jogadorC.Chuta());
            System.Console.Write(_jogadorC.Passe());

        }
    }
}