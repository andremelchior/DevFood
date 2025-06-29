﻿using Users;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hm = new Home();
            MessageBox.Show($"Você já está na tela de {hm.Text}");
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
            cadFunc.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblHome.Text = $"Olá, seja bem-vindo(a) {LoginFuncionario.f.Nome}! DevFood é um sistema de gerenciamento de " +
                $"pedidos, pratos e funcionarios de um restaurante. Você consegue acessar as guias através da barra lateral de navegação, " +
                $"contendo no menu a página de Home, Pedido, Pratos e Cadastro de Funcionarios.";
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

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            var fun = new CadastroFuncionario();
            fun.Show();
            this.Hide();
        }
    }
}
