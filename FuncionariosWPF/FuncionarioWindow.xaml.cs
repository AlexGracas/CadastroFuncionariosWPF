using FuncionariosWPF.ViewModel;
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
    /// Lógica interna para FuncionarioWindow.xaml
    /// </summary>
    public partial class FuncionarioWindow : Window
    {
        public FuncionarioViewModel FuncionarioViewModel { get; set; }
        public FuncionarioWindow()
        {
            InitializeComponent();
            this.FuncionarioViewModel = new FuncionarioViewModel();
            DataContext = this.FuncionarioViewModel;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {
                this.FuncionarioViewModel.Salvar();
            }
            this.Close();
        }
    }
}
