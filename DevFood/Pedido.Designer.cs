namespace DevFood
{
    partial class frmPedido
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPratos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.lblTaxa2 = new System.Windows.Forms.Label();
            this.txtTaxa2 = new System.Windows.Forms.TextBox();
            this.cmbItem5 = new System.Windows.Forms.ComboBox();
            this.txtQtd5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbItem4 = new System.Windows.Forms.ComboBox();
            this.txtQtd4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbItem3 = new System.Windows.Forms.ComboBox();
            this.txtQtd3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.txtVlrTaxa = new System.Windows.Forms.TextBox();
            this.rdComTaxas = new System.Windows.Forms.RadioButton();
            this.chkTaxa2 = new System.Windows.Forms.CheckBox();
            this.rdSemTaxas = new System.Windows.Forms.RadioButton();
            this.cmbItem1 = new System.Windows.Forms.ComboBox();
            this.chkTaxa1 = new System.Windows.Forms.CheckBox();
            this.cmbItem2 = new System.Windows.Forms.ComboBox();
            this.txtQtd2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtd1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.splitContainer1.Panel1.Controls.Add(this.btnFechar);
            this.splitContainer1.Panel1.Controls.Add(this.btnSair);
            this.splitContainer1.Panel1.Controls.Add(this.btnFuncionario);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.btnPratos);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(-13, 396);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(146, 40);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(-13, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(146, 40);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.MediumPurple;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFuncionario.Location = new System.Drawing.Point(-13, 151);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(146, 40);
            this.btnFuncionario.TabIndex = 11;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MediumPurple;
            this.button3.Location = new System.Drawing.Point(-13, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Pedido";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPratos
            // 
            this.btnPratos.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPratos.FlatAppearance.BorderSize = 0;
            this.btnPratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPratos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPratos.Location = new System.Drawing.Point(-13, 112);
            this.btnPratos.Name = "btnPratos";
            this.btnPratos.Size = new System.Drawing.Size(146, 40);
            this.btnPratos.TabIndex = 9;
            this.btnPratos.Text = "Pratos";
            this.btnPratos.UseVisualStyleBackColor = false;
            this.btnPratos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumPurple;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(-13, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodFunc);
            this.panel1.Controls.Add(this.lblCodFunc);
            this.panel1.Controls.Add(this.btnFazerPedido);
            this.panel1.Controls.Add(this.lblTaxa2);
            this.panel1.Controls.Add(this.txtTaxa2);
            this.panel1.Controls.Add(this.cmbItem5);
            this.panel1.Controls.Add(this.txtQtd5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbItem4);
            this.panel1.Controls.Add(this.txtQtd4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbItem3);
            this.panel1.Controls.Add(this.txtQtd3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTaxa);
            this.panel1.Controls.Add(this.txtVlrTaxa);
            this.panel1.Controls.Add(this.rdComTaxas);
            this.panel1.Controls.Add(this.chkTaxa2);
            this.panel1.Controls.Add(this.rdSemTaxas);
            this.panel1.Controls.Add(this.cmbItem1);
            this.panel1.Controls.Add(this.chkTaxa1);
            this.panel1.Controls.Add(this.cmbItem2);
            this.panel1.Controls.Add(this.txtQtd2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtQtd1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNumeroMesa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumeroPedido);
            this.panel1.Location = new System.Drawing.Point(31, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 359);
            this.panel1.TabIndex = 3;
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(134, 96);
            this.txtCodFunc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(68, 20);
            this.txtCodFunc.TabIndex = 37;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Location = new System.Drawing.Point(27, 98);
            this.lblCodFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(90, 13);
            this.lblCodFunc.TabIndex = 36;
            this.lblCodFunc.Text = "Cod. Funcionario:";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.BackColor = System.Drawing.Color.MediumPurple;
            this.btnFazerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFazerPedido.Location = new System.Drawing.Point(30, 312);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(103, 23);
            this.btnFazerPedido.TabIndex = 35;
            this.btnFazerPedido.Text = "Cadastrar Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = false;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // lblTaxa2
            // 
            this.lblTaxa2.AutoSize = true;
            this.lblTaxa2.Enabled = false;
            this.lblTaxa2.Location = new System.Drawing.Point(450, 120);
            this.lblTaxa2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxa2.Name = "lblTaxa2";
            this.lblTaxa2.Size = new System.Drawing.Size(82, 13);
            this.lblTaxa2.TabIndex = 34;
            this.lblTaxa2.Text = "% Taxa Couvert";
            this.lblTaxa2.Visible = false;
            this.lblTaxa2.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // txtTaxa2
            // 
            this.txtTaxa2.Enabled = false;
            this.txtTaxa2.Location = new System.Drawing.Point(543, 118);
            this.txtTaxa2.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaxa2.Name = "txtTaxa2";
            this.txtTaxa2.Size = new System.Drawing.Size(47, 20);
            this.txtTaxa2.TabIndex = 33;
            this.txtTaxa2.Visible = false;
            this.txtTaxa2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cmbItem5
            // 
            this.cmbItem5.FormattingEnabled = true;
            this.cmbItem5.Location = new System.Drawing.Point(98, 263);
            this.cmbItem5.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem5.Name = "cmbItem5";
            this.cmbItem5.Size = new System.Drawing.Size(110, 21);
            this.cmbItem5.TabIndex = 32;
            // 
            // txtQtd5
            // 
            this.txtQtd5.Location = new System.Drawing.Point(302, 264);
            this.txtQtd5.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd5.Name = "txtQtd5";
            this.txtQtd5.Size = new System.Drawing.Size(42, 20);
            this.txtQtd5.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Qtd. Itens";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "5º Item";
            // 
            // cmbItem4
            // 
            this.cmbItem4.FormattingEnabled = true;
            this.cmbItem4.Location = new System.Drawing.Point(98, 234);
            this.cmbItem4.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem4.Name = "cmbItem4";
            this.cmbItem4.Size = new System.Drawing.Size(110, 21);
            this.cmbItem4.TabIndex = 28;
            // 
            // txtQtd4
            // 
            this.txtQtd4.Location = new System.Drawing.Point(302, 235);
            this.txtQtd4.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd4.Name = "txtQtd4";
            this.txtQtd4.Size = new System.Drawing.Size(42, 20);
            this.txtQtd4.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Qtd. Itens";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "4º Item";
            // 
            // cmbItem3
            // 
            this.cmbItem3.FormattingEnabled = true;
            this.cmbItem3.Location = new System.Drawing.Point(98, 205);
            this.cmbItem3.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem3.Name = "cmbItem3";
            this.cmbItem3.Size = new System.Drawing.Size(110, 21);
            this.cmbItem3.TabIndex = 24;
            // 
            // txtQtd3
            // 
            this.txtQtd3.Location = new System.Drawing.Point(302, 206);
            this.txtQtd3.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd3.Name = "txtQtd3";
            this.txtQtd3.Size = new System.Drawing.Size(42, 20);
            this.txtQtd3.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Qtd. Itens";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "3º Item";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Enabled = false;
            this.lblTaxa.Location = new System.Drawing.Point(450, 93);
            this.lblTaxa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(81, 13);
            this.lblTaxa.TabIndex = 20;
            this.lblTaxa.Text = "% Taxa Serviço";
            this.lblTaxa.Visible = false;
            // 
            // txtVlrTaxa
            // 
            this.txtVlrTaxa.Enabled = false;
            this.txtVlrTaxa.Location = new System.Drawing.Point(543, 91);
            this.txtVlrTaxa.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrTaxa.Name = "txtVlrTaxa";
            this.txtVlrTaxa.Size = new System.Drawing.Size(47, 20);
            this.txtVlrTaxa.TabIndex = 19;
            this.txtVlrTaxa.Visible = false;
            // 
            // rdComTaxas
            // 
            this.rdComTaxas.AutoSize = true;
            this.rdComTaxas.Location = new System.Drawing.Point(317, 29);
            this.rdComTaxas.Margin = new System.Windows.Forms.Padding(2);
            this.rdComTaxas.Name = "rdComTaxas";
            this.rdComTaxas.Size = new System.Drawing.Size(74, 17);
            this.rdComTaxas.TabIndex = 18;
            this.rdComTaxas.TabStop = true;
            this.rdComTaxas.Text = "Com taxas";
            this.rdComTaxas.UseVisualStyleBackColor = true;
            this.rdComTaxas.CheckedChanged += new System.EventHandler(this.rdComTaxas_CheckedChanged_1);
            // 
            // chkTaxa2
            // 
            this.chkTaxa2.AutoSize = true;
            this.chkTaxa2.Location = new System.Drawing.Point(452, 58);
            this.chkTaxa2.Margin = new System.Windows.Forms.Padding(2);
            this.chkTaxa2.Name = "chkTaxa2";
            this.chkTaxa2.Size = new System.Drawing.Size(103, 17);
            this.chkTaxa2.TabIndex = 16;
            this.chkTaxa2.Text = "Couvert Artistico";
            this.chkTaxa2.UseVisualStyleBackColor = true;
            this.chkTaxa2.Visible = false;
            this.chkTaxa2.CheckedChanged += new System.EventHandler(this.chkTaxa2_CheckedChanged_1);
            // 
            // rdSemTaxas
            // 
            this.rdSemTaxas.AutoSize = true;
            this.rdSemTaxas.Location = new System.Drawing.Point(317, 58);
            this.rdSemTaxas.Margin = new System.Windows.Forms.Padding(2);
            this.rdSemTaxas.Name = "rdSemTaxas";
            this.rdSemTaxas.Size = new System.Drawing.Size(74, 17);
            this.rdSemTaxas.TabIndex = 17;
            this.rdSemTaxas.TabStop = true;
            this.rdSemTaxas.Text = "Sem taxas";
            this.rdSemTaxas.UseVisualStyleBackColor = true;
            this.rdSemTaxas.CheckedChanged += new System.EventHandler(this.rdSemTaxas_CheckedChanged_1);
            // 
            // cmbItem1
            // 
            this.cmbItem1.FormattingEnabled = true;
            this.cmbItem1.Location = new System.Drawing.Point(98, 148);
            this.cmbItem1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem1.Name = "cmbItem1";
            this.cmbItem1.Size = new System.Drawing.Size(110, 21);
            this.cmbItem1.TabIndex = 14;
            this.cmbItem1.SelectedIndexChanged += new System.EventHandler(this.cmbItem1_SelectedIndexChanged);
            // 
            // chkTaxa1
            // 
            this.chkTaxa1.AutoSize = true;
            this.chkTaxa1.Location = new System.Drawing.Point(452, 29);
            this.chkTaxa1.Margin = new System.Windows.Forms.Padding(2);
            this.chkTaxa1.Name = "chkTaxa1";
            this.chkTaxa1.Size = new System.Drawing.Size(104, 17);
            this.chkTaxa1.TabIndex = 15;
            this.chkTaxa1.Text = "Taxa de Serviço";
            this.chkTaxa1.UseVisualStyleBackColor = true;
            this.chkTaxa1.Visible = false;
            this.chkTaxa1.CheckedChanged += new System.EventHandler(this.chkTaxa1_CheckedChanged);
            // 
            // cmbItem2
            // 
            this.cmbItem2.FormattingEnabled = true;
            this.cmbItem2.Location = new System.Drawing.Point(98, 177);
            this.cmbItem2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem2.Name = "cmbItem2";
            this.cmbItem2.Size = new System.Drawing.Size(110, 21);
            this.cmbItem2.TabIndex = 13;
            // 
            // txtQtd2
            // 
            this.txtQtd2.Location = new System.Drawing.Point(302, 178);
            this.txtQtd2.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd2.Name = "txtQtd2";
            this.txtQtd2.Size = new System.Drawing.Size(42, 20);
            this.txtQtd2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qtd. Itens";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "2º Item";
            // 
            // txtQtd1
            // 
            this.txtQtd1.Location = new System.Drawing.Point(302, 148);
            this.txtQtd1.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd1.Name = "txtQtd1";
            this.txtQtd1.Size = new System.Drawing.Size(42, 20);
            this.txtQtd1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd. Itens";
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(134, 59);
            this.txtNumeroMesa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.Size = new System.Drawing.Size(68, 20);
            this.txtNumeroMesa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "1º Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº Mesa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(134, 28);
            this.txtNumeroPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(68, 20);
            this.txtNumeroPedido.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(267, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Pedido";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbItem5;
        private System.Windows.Forms.TextBox txtQtd5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbItem4;
        private System.Windows.Forms.TextBox txtQtd4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbItem3;
        private System.Windows.Forms.TextBox txtQtd3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.TextBox txtVlrTaxa;
        private System.Windows.Forms.RadioButton rdComTaxas;
        private System.Windows.Forms.CheckBox chkTaxa2;
        private System.Windows.Forms.RadioButton rdSemTaxas;
        private System.Windows.Forms.ComboBox cmbItem1;
        private System.Windows.Forms.CheckBox chkTaxa1;
        private System.Windows.Forms.ComboBox cmbItem2;
        private System.Windows.Forms.TextBox txtQtd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroMesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPratos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblTaxa2;
        private System.Windows.Forms.TextBox txtTaxa2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblCodFunc;
    }
}

