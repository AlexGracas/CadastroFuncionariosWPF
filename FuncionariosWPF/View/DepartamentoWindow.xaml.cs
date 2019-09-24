using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FuncionariosWPF
{
    /// <summary>
    /// Lógica interna para DepartamentoWindow.xaml
    /// </summary>
    public partial class DepartamentoWindow : Window
    {
        public ViewModel.DepartamentoViewModel DepartamentoViewModel { get; set; }
        public DepartamentoWindow()
        {
            InitializeComponent();
            this.DepartamentoViewModel = new ViewModel.DepartamentoViewModel();
            this.DataContext = this.DepartamentoViewModel;
        }
    }
}
