using System;
using System.Collections.Generic;
using System.Text;

namespace MinesWeeper.Common.Models
{
    public class Peca
    {
        public bool Mina { get; private set; }
        public int Linha_p { get; private set; }
        public int Coluna_p { get; private set; }
    }
}
