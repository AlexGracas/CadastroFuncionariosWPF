using System.ComponentModel.DataAnnotations;

namespace Funcionarios
{
    public class Cidade
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}