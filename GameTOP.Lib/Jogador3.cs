using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste chuta. \n";
        }

        public string Corre()
        {
            return "Tetse corre. \n";
        }

        public string Passe()
        {
            return "Teste passa. \n";
        }
    }
}