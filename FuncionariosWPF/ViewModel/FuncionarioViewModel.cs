using Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosWPF.ViewModel
{
    public class FuncionarioViewModel
    {
        public 
            Funcionarios.Funcionario 
            Funcionario { get; set; }

        public FuncionarioViewModel()
        {
            this.Funcionario = new Funcionarios.Funcionario()
            {
                Nome = "Fulano de Tal",
                CPF = "111.111.111-22",
                Admissao = new DateTime(2018, 01, 01)
            };
            this.Funcionario.Lotacoes = new List<Lotacao>();
            Departamento departamento = new Departamento()
            {
                Nome = "Administração de Sistemas"
            };
            Cargo cargo = new Cargo()
            {
                Nome = "Chefe"
            };
            Cargo cargo2 = new Cargo()
            {
                Nome = "Auxiliar"
            };
            Lotacao l1 = new Lotacao();
            l1.Cargo = cargo2;
            l1.Departamento = departamento;
            l1.Inicio = new DateTime(2018, 01, 01);
            l1.Fim = new DateTime(2018, 12, 31);
            this.Funcionario.Lotacoes.Add(l1);

            Lotacao l2 = new Lotacao();
            l2.Cargo = cargo;
            l2.Departamento = departamento;
            l2.Inicio = new DateTime(2019, 01, 01);
            this.Funcionario.Lotacoes.Add(l2);

        }

    }
}
