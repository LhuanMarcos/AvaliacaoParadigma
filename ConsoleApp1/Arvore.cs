using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Arvore
    {
        public int Value;
        public Arvore Esquerda;
        public Arvore Direita;

        public Arvore(int value)
        {
            Value = value;
        }
    }
}
