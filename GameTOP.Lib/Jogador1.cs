using GameTOP.Interface;

namespace GameTOP.Lib
{
    
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        // Criando o CONSTRUTOR Jogador.
        public Jogador1(string Nome = "Eraldo")
        {
            _Nome = Nome;
        }

        // Chuta.
        public string Chuta()
        {
            return $"{_Nome} esta Chutando \n";
        }

        // Corre.
        public string Corre()
        {
            return $"{_Nome} esta Correndo \n";
        }

        // Passe.
        public string Passe()
        {
            return $"{_Nome} esta Passando \n";
        }

    }
}