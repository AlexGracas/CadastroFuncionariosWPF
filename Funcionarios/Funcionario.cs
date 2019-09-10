using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Funcionario : Pessoa
    {
        public IList<Lotacao> Lotacoes { get; set; }

        [Required]
        public DateTime Admissao { get; set; }

        public DateTime Demissao { get; set; }
    }
}
