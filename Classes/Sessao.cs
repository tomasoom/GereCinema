using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Sessao
    {
        public Sessao(DateTime dataInicio, Sala sala, Filme filme)
        {
            this.DataInicio = dataInicio;
            this.Sala = sala;
            this.Filme = filme;
        }

        public override string ToString()
        {
            return $"{this.Sala.NrSala}: {this.Filme.Titulo} - {this.DataInicio}";
        }

    }
}
