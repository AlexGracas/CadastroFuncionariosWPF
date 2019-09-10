using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String CPF { get; set; }
        public Endereco Endereco { get; set; }
    }
}
