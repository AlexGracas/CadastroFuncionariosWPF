using Funcionarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosWPF.ViewModel
{
    public class DepartamentoViewModel
    {
        public ObservableCollection<Departamento> Departamentos { get; set; }

        private ModelFuncionarios Context { get; set; }
        public DepartamentoViewModel()
        {
            this.Context = new ModelFuncionarios();
            this.Departamentos = new ObservableCollection<Departamento>(
                this.Context.Departamentos.ToList());
        }
    }
}
