namespace Estoque
{
    partial class FormEntrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPecas = new System.Windows.Forms.GroupBox();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.btClearAluno = new System.Windows.Forms.Button();
            this.btPesqAluno = new System.Windows.Forms.Button();
            this.txtDescCli = new System.Windows.Forms.TextBox();
            this.txtIDCli = new System.Windows.Forms.TextBox();
            this.ckbPedEstoq = new System.Windows.Forms.CheckBox();
            this.ckbSVO = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tmEntrada = new System.Windows.Forms.Timer(this.components);
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.gbPecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(124, 20);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(149, 71);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(474, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "REFRIGERADOR",
            "LAVADORA",
            "FREZZER",
            "PURIFICADOR",
            "FOGÃO",
            "FORNO",
            "MICROONDAS",
            "ASPIRADOR",
            "AR CONDICIONADO",
            "CLIMATIZADOR",
            "COIFA"});
            this.cbTipo.Location = new System.Drawing.Point(21, 114);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(202, 21);
            this.cbTipo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // gbPecas
            // 
            this.gbPecas.Controls.Add(this.dgvPecas);
            this.gbPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPecas.Location = new System.Drawing.Point(12, 173);
            this.gbPecas.Name = "gbPecas";
            this.gbPecas.Size = new System.Drawing.Size(751, 376);
            this.gbPecas.TabIndex = 3;
            this.gbPecas.TabStop = false;
            this.gbPecas.Text = "Peças Adicionadas:";
            // 
            // dgvPecas
            // 
            this.dgvPecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPecas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPecas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPecas.Location = new System.Drawing.Point(3, 16);
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.ReadOnly = true;
            this.dgvPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecas.Size = new System.Drawing.Size(745, 357);
            this.dgvPecas.TabIndex = 0;
            this.dgvPecas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPecas_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionar.BackgroundImage")));
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Location = new System.Drawing.Point(711, 114);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(35, 34);
            this.btAdicionar.TabIndex = 12;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.btClearAluno);
            this.gbInformacoes.Controls.Add(this.btPesqAluno);
            this.gbInformacoes.Controls.Add(this.txtDescCli);
            this.gbInformacoes.Controls.Add(this.txtIDCli);
            this.gbInformacoes.Controls.Add(this.ckbPedEstoq);
            this.gbInformacoes.Controls.Add(this.ckbSVO);
            this.gbInformacoes.Controls.Add(this.btAdicionar);
            this.gbInformacoes.Controls.Add(this.txtValor);
            this.gbInformacoes.Controls.Add(this.txtQuant);
            this.gbInformacoes.Controls.Add(this.txtCodigo);
            this.gbInformacoes.Controls.Add(this.cbTipo);
            this.gbInformacoes.Controls.Add(this.txtDescricao);
            this.gbInformacoes.Controls.Add(this.label3);
            this.gbInformacoes.Controls.Add(this.label7);
            this.gbInformacoes.Controls.Add(this.label1);
            this.gbInformacoes.Controls.Add(this.label2);
            this.gbInformacoes.Controls.Add(this.label6);
            this.gbInformacoes.Controls.Add(this.label5);
            this.gbInformacoes.Controls.Add(this.label4);
            this.gbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacoes.Location = new System.Drawing.Point(8, 8);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(752, 159);
            this.gbInformacoes.TabIndex = 40;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações:";
            // 
            // btClearAluno
            // 
            this.btClearAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClearAluno.BackgroundImage")));
            this.btClearAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearAluno.FlatAppearance.BorderSize = 0;
            this.btClearAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearAluno.Location = new System.Drawing.Point(522, 24);
            this.btClearAluno.Name = "btClearAluno";
            this.btClearAluno.Size = new System.Drawing.Size(35, 34);
            this.btClearAluno.TabIndex = 3;
            this.btClearAluno.UseVisualStyleBackColor = true;
            // 
            // btPesqAluno
            // 
            this.btPesqAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqAluno.BackgroundImage")));
            this.btPesqAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqAluno.FlatAppearance.BorderSize = 0;
            this.btPesqAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqAluno.Location = new System.Drawing.Point(563, 24);
            this.btPesqAluno.Name = "btPesqAluno";
            this.btPesqAluno.Size = new System.Drawing.Size(35, 34);
            this.btPesqAluno.TabIndex = 4;
            this.btPesqAluno.UseVisualStyleBackColor = true;
            this.btPesqAluno.Click += new System.EventHandler(this.btPesqAluno_Click);
            // 
            // txtDescCli
            // 
            this.txtDescCli.Location = new System.Drawing.Point(95, 32);
            this.txtDescCli.Name = "txtDescCli";
            this.txtDescCli.ReadOnly = true;
            this.txtDescCli.Size = new System.Drawing.Size(414, 20);
            this.txtDescCli.TabIndex = 2;
            // 
            // txtIDCli
            // 
            this.txtIDCli.Location = new System.Drawing.Point(19, 32);
            this.txtIDCli.Name = "txtIDCli";
            this.txtIDCli.ReadOnly = true;
            this.txtIDCli.Size = new System.Drawing.Size(70, 20);
            this.txtIDCli.TabIndex = 1;
            // 
            // ckbPedEstoq
            // 
            this.ckbPedEstoq.AutoSize = true;
            this.ckbPedEstoq.Location = new System.Drawing.Point(608, 35);
            this.ckbPedEstoq.Name = "ckbPedEstoq";
            this.ckbPedEstoq.Size = new System.Drawing.Size(147, 17);
            this.ckbPedEstoq.TabIndex = 5;
            this.ckbPedEstoq.Text = "Pedido para estoque.";
            this.ckbPedEstoq.UseVisualStyleBackColor = true;
            this.ckbPedEstoq.Click += new System.EventHandler(this.ckbPedEstoq_Click);
            // 
            // ckbSVO
            // 
            this.ckbSVO.AutoSize = true;
            this.ckbSVO.Location = new System.Drawing.Point(485, 118);
            this.ckbSVO.Name = "ckbSVO";
            this.ckbSVO.Size = new System.Drawing.Size(118, 17);
            this.ckbSVO.TabIndex = 11;
            this.ckbSVO.Text = "Pedido em SVO.";
            this.ckbSVO.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(371, 114);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(82, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(252, 114);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(73, 20);
            this.txtQuant.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Destinatario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(688, 555);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tmEntrada
            // 
            this.tmEntrada.Tick += new System.EventHandler(this.tmEntrada_Tick);
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.Location = new System.Drawing.Point(15, 555);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(108, 23);
            this.btNovoCliente.TabIndex = 13;
            this.btNovoCliente.Text = "Novo cliente";
            this.btNovoCliente.UseVisualStyleBackColor = true;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 590);
            this.Controls.Add(this.btNovoCliente);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.gbPecas);
            this.Controls.Add(this.gbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.FormEntrada_Load);
            this.gbPecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPecas;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbSVO;
        private System.Windows.Forms.CheckBox ckbPedEstoq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmEntrada;
        private System.Windows.Forms.Button btClearAluno;
        private System.Windows.Forms.Button btPesqAluno;
        private System.Windows.Forms.TextBox txtDescCli;
        private System.Windows.Forms.TextBox txtIDCli;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNovoCliente;
    }
}