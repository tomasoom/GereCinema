using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Venda
    {

        public double getPreco()
        {
            double preco = 0;
            foreach(Item item in this.Items)
            {
                preco+=item.Preco;
            }
            foreach(Bilhete bilhete in this.Bilhetes)
            {
                preco += bilhete.Sessao.Filme.Preco;
            }
            return preco;
        }

        public override string ToString()
        {
            return $"{this.Cliente} - {this.Funcionario} - Preço: {getPreco()}";
        }
    }
}
