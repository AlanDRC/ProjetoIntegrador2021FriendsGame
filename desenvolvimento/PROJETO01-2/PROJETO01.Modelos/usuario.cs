using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class usuario
    {
         public string codPlayer { get; set; }

        public string IdLogin { get; set; }

        public string NickJogador { get; set; }
        public string senha { get; set; }
        public int codJogo { get; set; }
        public jogo jogo { get; set; }

    }
}
