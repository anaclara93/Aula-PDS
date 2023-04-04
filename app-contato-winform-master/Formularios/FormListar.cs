using AppContatoForm.Formularios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

                                                                       /*Doc certo*/
namespace AppContatoForm
{
    public partial class FormListar : Form
    {
        private List<Contato> ListaContato = new List<Contato>();

        private MySqlConnection conexao;

        private MySqlCommand comando;

        public FormListar()
        {
            InitializeComponent();
            Conexao();
            CarregarLista();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }
        private void CarregarLista()
        {
            MySqlCommand comando = new MySqlCommand("SELECT *FROM contato",conexao);
            MySqlDataAdapter da=new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvContato.DataSource = dt;
        }

        private void dgvContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
