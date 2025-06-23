using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace DevFood
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroItens pratos = new CadastroItens();
            pratos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadFunc = new CadastroFuncionario();
            MessageBox.Show($"Você já está na tela de {cadFunc.Text}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var lg = new LoginFuncionario();
            lg.Show();
            this.Hide();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.cadastrar(txtId.Text, txtNome.Text, txtEmail.Text, txtCargo.Text, txtCPF.Text, txtSenha.Text);

            var conn = new DAO.Dao();
            if(conn.cadastrarFuncionario(funcionario))
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                txtNome.Clear();
                txtCPF.Clear();
                txtSenha.Clear();
                txtCargo.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcionário.");
            }
        }
    }
}
