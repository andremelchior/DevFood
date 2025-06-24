namespace DevFood
{
    partial class CadastroItens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblPratos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCaadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblPratos);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
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
            this.btnFechar.TabIndex = 18;
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
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(-13, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 40);
            this.button4.TabIndex = 16;
            this.button4.Text = "Funcionario";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(-13, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "Pedido";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(-13, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pratos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button5.TabIndex = 13;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblPratos
            // 
            this.lblPratos.AutoSize = true;
            this.lblPratos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPratos.Location = new System.Drawing.Point(212, 33);
            this.lblPratos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPratos.Name = "lblPratos";
            this.lblPratos.Size = new System.Drawing.Size(257, 33);
            this.lblPratos.TabIndex = 2;
            this.lblPratos.Text = "Cadastrar Pratos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.cmbCategorias);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.btnCaadastrar);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(121, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 277);
            this.panel1.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(266, 202);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 25);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(43, 65);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(115, 61);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(133, 21);
            this.cmbCategorias.TabIndex = 9;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(331, 58);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(45, 20);
            this.txtPreco.TabIndex = 8;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(275, 61);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(115, 104);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(261, 59);
            this.txtDesc.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(43, 107);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(55, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descrição";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(331, 28);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(45, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(275, 31);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // btnCaadastrar
            // 
            this.btnCaadastrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCaadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCaadastrar.Location = new System.Drawing.Point(145, 202);
            this.btnCaadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaadastrar.Name = "btnCaadastrar";
            this.btnCaadastrar.Size = new System.Drawing.Size(66, 25);
            this.btnCaadastrar.TabIndex = 2;
            this.btnCaadastrar.Text = "Cadastrar";
            this.btnCaadastrar.UseVisualStyleBackColor = false;
            this.btnCaadastrar.Click += new System.EventHandler(this.btnCaadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 31);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // CadastroItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CadastroItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pratos";
            this.Load += new System.EventHandler(this.CadastroItens_Load);
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
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCaadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblPratos;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnLimpar;
    }
}