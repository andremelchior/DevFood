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

namespace DevFood
{
    public partial class CadastroItens : Form
    {
        public CadastroItens()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroItens_Load(object sender, EventArgs e)
        {
            cmbCategorias.Items.Clear();
            cmbCategorias.Text = "[Selecione]";
            var conn = new Dao();
            string[] categoria = new string[4];

            for (int i = 0; i < categoria.Length; i++)
            {
                categoria[i] = conn.pegarCategoria(i + 1);
                //MessageBox.Show(categoria[i]);
                cmbCategorias.Items.Add(categoria[i]);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var lg = new LoginFuncionario();
            lg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var prat = new CadastroItens();
            MessageBox.Show($"Você já está na tela de {prat.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ped = new frmPedido();
            ped.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var func = new CadastroFuncionario();
            func.Show();
            this.Hide();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCaadastrar_Click(object sender, EventArgs e)
        {
            var conn = new Dao();

            if (txtNumero.Text == "")
            {
                if (conn.cadastrarPrato(txtNome.Text, txtDesc.Text, cmbCategorias.Text, txtPreco.Text))
                {
                    MessageBox.Show("Prato cadastrado com sucesso! O código do prato foi atribuído automaticamente.");
                }
            }
            else if (conn.cadastrarPrato(txtNumero.Text, txtNome.Text, txtDesc.Text, cmbCategorias.Text, txtPreco.Text))
            {
                MessageBox.Show("Prato cadastrado com sucesso!");
            }
            else 
            { 
                MessageBox.Show("Não foi possível cadastrar o prato! Tente novamente.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtNome.Text = "";
            txtDesc.Text = "";
            txtPreco.Text = "";
            cmbCategorias.Text = "[Selecione]";
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
