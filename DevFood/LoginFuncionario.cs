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
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form home = new Home(); 
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("CPF ou senha inválidos! tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaindoMsg saindo = new SaindoMsg();


                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    Application.Exit();
                };
                timer.Start();
                saindo.Show();
            }
            else
            {
                MessageBox.Show("Você cancelou a ação de sair.", "Ação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = System.Drawing.Color.MediumPurple;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.ForeColor = System.Drawing.Color.White;
        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {
            btnSair.BackColor = System.Drawing.Color.MediumPurple;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.ForeColor = System.Drawing.Color.White;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = System.Drawing.Color.White;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.ForeColor = System.Drawing.Color.MediumPurple;
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_Click(object sender, EventArgs e)
        {
            txtCpf.SelectionStart = 0;
        }
    }
}
