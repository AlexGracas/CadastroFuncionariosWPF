using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        public String Rua { get; set; }
        public String CEP { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }

        [Required]
        public Cidade Cidade { get; set; }
    }
}
