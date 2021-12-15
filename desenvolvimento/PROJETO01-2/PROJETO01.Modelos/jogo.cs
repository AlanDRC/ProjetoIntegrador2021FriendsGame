 using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
   public class jogo
    {
        public int codJogo { get; set; }
        public string nomeDoJogo { get; set; }
        public string codFornecedor { get; set; }
        public Fornecedorjogos Fornecedorjogos { get; set; }
        public DateTime anolancamento { get; set; }
        public string requisitos { get; set; }
        public string codTipoJogo { get; set; }
        public TipoJogos TipoJogos { get; set; }

    }
}
