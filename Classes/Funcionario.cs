using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Funcionario
    {
        private CinemaDBContainer db = new CinemaDBContainer();
        public Funcionario(string nome, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.CodFuncionario = $"f{(db.Funcionarios.Count())+1.ToString()}";
        }

        public override string ToString()
        {
            return $"{this.CodFuncionario}  {this.Nome}  {this.Salario}€";
        }
    }
}
