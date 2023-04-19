using AtividadePDS.RegrasdeNegocios;
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

namespace AtividadePDS
{
    /// <summary>
    /// Lógica interna para CadastroQuartos.xaml
    /// </summary>
    public partial class CadastroQuartos : Window
    {
        public CadastroQuartos()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            
                Quartos quarto = new Quartos();
                quarto.Tipo = txtTipo.Text;
                quarto.ValorDiaria = Convert.ToDouble(txtDiarias.Text);

            
        }
    }
}
