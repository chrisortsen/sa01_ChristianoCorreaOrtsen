using System;
using System.Collections.Generic;
using System.Text;

namespace SA01_ChristianoCorreaOrtsen
{
    class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public Produto(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

    }
}
