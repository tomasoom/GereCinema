using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Bilhete
    {
        public Bilhete()
        {

        }
        public Bilhete(Sessao sessao, Lugar lugar)
        {
            this.Sessao = sessao;
            this.X = lugar.X;
            this.Y = lugar.Y;
        }

        public override string ToString()
        {
            return $"{IdBilhete} {this.Sessao.Filme.Titulo} - Preço: {this.Sessao.Filme.Preco}";
        }
    }
}
