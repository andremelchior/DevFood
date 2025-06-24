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
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.BorderColor = btnSair.BackColor;

            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.BorderColor = btnSair.BackColor;
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
            btnFechar.BackColor = Color.FromArgb(132, 100, 197);

            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar o programa?", "Fechar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaindoMsg fechando = new SaindoMsg();


                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    Application.Exit();
                };
                timer.Start();
                fechando.lblMsg.Text = "Fechando...";
                fechando.Show();
            }
            else
            {
                MessageBox.Show("Você cancelou a ação de fechar o programa.", "Ação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnFechar.BackColor = Color.MediumPurple;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(132, 100, 197);

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
                    this.Hide();
                    var lg = new LoginFuncionario();
                    lg.Show();
                };
                timer.Start();
                saindo.Show();
            }
            else
            {
                MessageBox.Show("Você cancelou a ação de sair.", "Ação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSair.BackColor = Color.MediumPurple;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == txtConfirmarSenha.Text)
            {
                Funcionario funcionario = new Funcionario();


                if (txtId.Text == "")
                {
                    funcionario.cadastrar(txtNome.Text, txtCargo.Text, txtEmail.Text, txtCPF.Text, txtSenha.Text);
                }
                else
                {
                    funcionario.cadastrar(int.Parse(txtId.Text), txtNome.Text, txtCargo.Text, txtEmail.Text, txtCPF.Text, txtSenha.Text);
                }


                var conn = new DAO.Dao();
                if(conn.cadastrarFuncionario(funcionario))
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Erro! As senhas não coincidem, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmarSenha.Text)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.cadastrar(int.Parse(txtId.Text), txtNome.Text, txtCargo.Text, txtEmail.Text, txtCPF.Text, txtSenha.Text);

                var conn = new DAO.Dao();
                if (conn.atualizarFuncionario(funcionario))
                {
                    MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtSenha.Clear();
                    txtCargo.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar funcionário.");
                }

            }
            else
            {
                MessageBox.Show("Erro! As senhas não coincidem, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            f.Id = int.Parse(txtId.Text);

            var conn = new DAO.Dao();
            if (conn.consultarFuncionario(f))
            {
                txtNome.Text = f.Nome;
                txtEmail.Text = f.Email;
                txtCargo.Text = f.Cargo;
                txtCPF.Text = f.Cpf;
                txtSenha.Text = f.Senha;
                txtSenha.UseSystemPasswordChar = false;
                txtConfirmarSenha.Clear();
                MessageBox.Show($"Funcionário {f.Nome} encontrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtSenha.Clear();
            txtCargo.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtSenha.UseSystemPasswordChar = true;
            MessageBox.Show("Formulário limpo com sucesso!", "Limpeza", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;

            Funcionario f = new Funcionario();

            f.Id = int.Parse(txtId.Text);

            var conn = new DAO.Dao();
            if (conn.deletarFuncionario(f))
            {
                MessageBox.Show($"Funcionário {f.Nome} deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro! Não foi possivel deletar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
