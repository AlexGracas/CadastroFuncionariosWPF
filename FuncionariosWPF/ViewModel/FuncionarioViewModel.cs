using Funcionarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosWPF.ViewModel
{
    public class FuncionarioViewModel
    {
        public ObservableCollection<Funcionarios.Funcionario>
            Funcionarios
        { get; set; }

        public 
            Funcionarios.Funcionario 
            Funcionario { get; set; }

        public IList<Departamento> Departamentos { get; set; }

        public IList<Cargo> Cargos { get; set; }

        ModelFuncionarios context = new ModelFuncionarios();

        public FuncionarioViewModel()
        {
            this.Funcionarios = new ObservableCollection<Funcionario>(context.Funcionarios.ToList());
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }
    }
}
