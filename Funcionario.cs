//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GereCinema
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            this.Vendas = new HashSet<Venda>();
        }
    
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string CodFuncionario { get; set; }
        public double Salario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
