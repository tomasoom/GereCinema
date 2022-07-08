using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
  
    public partial class Filme
    {
        public Filme(string titulo, string tipo, int limIdade, int duracao, double preco)
        {
            this.Titulo = titulo;
            this.Tipo = tipo;  
            this.LimIdade = limIdade;
            this.Duracao = duracao;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return $"{this.Titulo}  {this.Tipo}  +{this.LimIdade} {this.Duracao}min";
        }
    }
}
