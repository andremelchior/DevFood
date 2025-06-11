using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using PessoaFuncionario;

namespace DevFood
{
    public partial class LoginFuncionario : Form
    {
        public Dao connect;
        public Pessoa p;

        public LoginFuncionario()
        {
            InitializeComponent();
            connect = new Dao();
            p = new Pessoa();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifica com método para validacao
            connect.login(p);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            p.Cpf = long.Parse(txtCpf.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            p.Senha = txtSenha.Text;
        }

        private void LoginFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
