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
using Users;

namespace DevFood
{
    public partial class LoginFuncionario : Form
    {
        public Dao connect;
        public static Funcionario f;

        public LoginFuncionario()
        {
            InitializeComponent();
            connect = new Dao();
            f = new Funcionario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifica com método para validacao
            f.Cpf = txtCpf.Text;
            f.Senha = txtSenha.Text;
            if (connect.login(f))
            {
                MessageBox.Show("Login realizado com sucesso!");
                Form home = new Home(); 
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("CPF ou senha inválidos! tente novamente.");
                txtCpf.Clear();
                txtSenha.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void LoginFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
