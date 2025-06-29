﻿using System;
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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
            rdComTaxas.Checked = true;
            chkTaxa1.Checked = true;

            if (LoginFuncionario.f.Cargo != "administrador" && LoginFuncionario.f.Cargo != "gerente")
            {
                btnFuncionario.Visible = false;
                btnPratos.Visible = false;
            }

            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.BorderColor = btnSair.BackColor;

            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.BorderColor = btnSair.BackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var conn = new Dao();

            try
            {
                if (conn.verificarPratos() > 0)
                {
                    cmbItem1.Items.Clear();
                    cmbItem2.Items.Clear();
                    cmbItem3.Items.Clear();
                    cmbItem4.Items.Clear();
                    cmbItem5.Items.Clear();
                    cmbItem1.Text = "[Selecione]";
                    cmbItem2.Text = "[Selecione]";
                    cmbItem3.Text = "[Selecione]";
                    cmbItem4.Text = "[Selecione]";
                    cmbItem5.Text = "[Selecione]";

                    string[] pratos = new string[conn.verificarPratos()];
                    int tamanho = conn.verificarPratos();

                    int j = 0;
                    for (int i = 0; i < pratos.Length; i++)
                    {
                        j++;
                        while(true)//1 = null? (V)
                        {
                            if (conn.pegarPrato(j) != null)
                            {
                                pratos[i] = conn.pegarPrato(j);
                                cmbItem1.Items.Add(pratos[i]);
                                cmbItem2.Items.Add(pratos[i]);
                                cmbItem3.Items.Add(pratos[i]);
                                cmbItem4.Items.Add(pratos[i]);
                                cmbItem5.Items.Add(pratos[i]);
                                break;
                            }
                            j++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os pratos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void rdComTaxas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdComTaxas.Checked)
            {
                chkTaxa1.Visible = true;
                chkTaxa2.Visible = true;
                lblTaxa.Visible = true;
                txtVlrTaxa.Visible = true;
            }
        }

        private void rdSemTaxas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSemTaxas.Checked)
            {
                chkTaxa1.Visible = false;
                chkTaxa2.Visible = false;

                chkTaxa1.Checked = false;
                chkTaxa2.Checked = false;
            }
        }

        private void chkTaxa2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaxa2.Checked)
            {
                txtTaxa2.Enabled = true;
                lblTaxa2.Enabled = true;
            }
            else
            {
                txtTaxa2.Enabled = false;
                lblTaxa2.Enabled = false;
            }

            //if (chkTaxa2.Checked)
            //{
            //    
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTaxa1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaxa1.Checked)
            {
                txtVlrTaxa.Enabled = true;
                txtVlrTaxa.Visible = true;

                lblTaxa.Enabled = true;
                lblTaxa.Visible = true;
                lblTaxa2.Visible = true;

            }
            else
            {
                txtVlrTaxa.Enabled = false;
                lblTaxa.Enabled = false;
                txtVlrTaxa.Visible = false;


            }

        }

        private void rdSemTaxas_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rdComTaxas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdComTaxas.Checked)
            {
                chkTaxa1.Checked = true;
                chkTaxa1.Visible = true;
                chkTaxa2.Visible = true;
            }
            else
            {
                chkTaxa1.Checked = false;
                chkTaxa1.Visible = false;
                chkTaxa2.Checked = false;
                chkTaxa2.Visible = false;
                lblTaxa.Visible = false;
                lblTaxa2.Visible = false;
            }
        }

        private void chkTaxa2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTaxa2.Checked)
            {
                txtTaxa2.Enabled = true;
                txtTaxa2.Visible = true;
                lblTaxa2.Enabled = true;
                lblTaxa2.Enabled = true;
            }
            else
            {

                txtTaxa2.Enabled = false;
                txtTaxa2.Visible = false;
                lblTaxa2.Enabled = false;
                lblTaxa2.Enabled = false;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formPed = new frmPedido();
            MessageBox.Show($"Você já está na tela de {formPed.Text}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var prato = new CadastroItens();
            prato.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cadFunc = new CadastroFuncionario();
            cadFunc.Show();
            this.Hide();
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

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            var conn = new Dao();

            if(conn.cadastrarPedido(txtNumeroPedido.Text, txtNumeroMesa.Text, txtVlrTaxa.Text, cmbItem1.Text, txtQtd1.Text, txtCodFunc.Text))
            {
                MessageBox.Show("Pedido realizado com sucesso!");
                txtNumeroPedido.Clear();
                txtNumeroMesa.Clear();
                cmbItem1.Text = "[Selecione]";
                txtQtd1.Clear();
                txtCodFunc.Clear();
            }
            else
            {
                MessageBox.Show("Erro! não foi possível fazer o pedido.");
            }
        }

        private void cmbItem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conn = new Dao();
            
        }
    }
}
