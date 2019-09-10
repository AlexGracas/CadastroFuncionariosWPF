using System;
using System.ComponentModel.DataAnnotations;

namespace Funcionarios
{
    public class Lotacao
    {
        public int Id { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        [Required]
        public Cargo Cargo { get; set; }

        [Required]
        public Departamento Departamento {get; set; }
    }
}