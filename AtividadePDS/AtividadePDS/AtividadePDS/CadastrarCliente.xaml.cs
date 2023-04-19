using AtividadePDS.RegrasdeNegocios;
using FerramentasBiblioteca.Formatacoes;
using FerramentasBiblioteca.Validacoes;
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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string Cpf = Mascaras.ColocarMascaraCPF(txtCpf.Text);
            bool validarCpf = ValidacoesSociais.ValidarCpf(Cpf);

            if (validarCpf == true)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Email = txtEmail.Text;

            }
            else
            {

                //desabilitar componentes
                txtNome.AcceptsReturn = false;
                txtCpf.AcceptsReturn = false;
                txtEmail.AcceptsReturn = false;
                txtTelefone.AcceptsReturn = false;
                btSalvar.AllowDrop = false;
                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
            }
        }

    
    }
}
