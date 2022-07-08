using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    
    public partial class Sala
    {
        public Sala(int nrSala, int comprimento, int largura)
        {
            this.NrSala = nrSala;
            this.Comprimento = comprimento;
            this.Largura = largura;
        }

        public override string ToString()
        {
            return $"Sala nº: {this.NrSala} de {this.Comprimento * this.Largura} lugares";
        }
    }
}
