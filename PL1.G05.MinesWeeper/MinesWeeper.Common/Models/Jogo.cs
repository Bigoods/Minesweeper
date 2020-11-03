using System;
using System.Collections.Generic;
using System.Text;

namespace MinesWeeper.Common.Models
{
    public class Jogo
    {
        private int tamanhoPequeno = 9;
        private int tamanhoMedio = 16;
        public int NumbMinas { get; private set; }
        public int Matriz { get; private set; }
        public int TamanhoPequeno 
        {
            get { return tamanhoPequeno; } 
            private set { tamanhoPequeno = value; }
        }
        public int TamanhoMedio
        {
            get { return tamanhoMedio; }
            private set { tamanhoMedio = value; }
        }

        public DateTime Tempo { get; private set; }
        public string Dificuldade { get; private set; }
    }
}
