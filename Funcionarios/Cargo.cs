using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Funcionarios
{
    public class Cargo
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Atribuicao {get;set;}

        public decimal SalarioBase { get; set; }

        public IList<Departamento> Departamentos { get; set; }
    }
}