using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Cliente
    {
        public Cliente(string nome, int idade, string nIF)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.NIF = nIF;
            
        }

        public override string ToString()
        {
            return $"{this.Nome}, {this.Idade} anos , {this.NIF}";
        }
    }
}
