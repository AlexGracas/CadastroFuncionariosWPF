using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Funcionarios
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public IList<Cargo> Cargos { get; set; }
    }
}