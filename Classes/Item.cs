using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Item
    {
        public Item(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return $"Item nº: {this.IdItem}: {this.Nome} - {this.Preco}";
        }
    }
}
