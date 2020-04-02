using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "\nTeste Chuta";
        }

        public string Corre()
        {
            return "\nTeste Corre";   
        }

        public string Passe()
        {
            return "\nTeste Passe";   
        }
    }
}