using GameTOP.Interface;

namespace GameTOP.lib
{
      public class Jogador1 : IJogador {

        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Chuta()
        {
           return $"{_Nome} esta chutando\n";
        }

        public string Corre()
        {
            return $"{_Nome} esta corrrendo\n";
        }

        public string Passe()
        {
            return $"{_Nome} esta passando\n";
        }
    }
}