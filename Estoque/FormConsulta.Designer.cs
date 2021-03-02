namespace Estoque
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.tbConsulta = new System.Windows.Forms.TabControl();
            this.tabPeca = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbSVO = new System.Windows.Forms.CheckBox();
            this.mskFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPecasVendidas = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPecasVendidas = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPesqPecasVend = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvPesqCli = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.venderPeçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.txtPesqCli = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbConsulta.SuspendLayout();
            this.tabPeca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPecasVendidas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasVendidas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqCli)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.tabPeca);
            this.tbConsulta.Controls.Add(this.tabPecasVendidas);
            this.tbConsulta.Controls.Add(this.tabCliente);
            this.tbConsulta.Location = new System.Drawing.Point(12, 12);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.SelectedIndex = 0;
            this.tbConsulta.Size = new System.Drawing.Size(1015, 636);
            this.tbConsulta.TabIndex = 4;
            this.tbConsulta.Click += new System.EventHandler(this.tbConsulta_Click);
            // 
            // tabPeca
            // 
            this.tabPeca.Controls.Add(this.groupBox1);
            this.tabPeca.Controls.Add(this.txtPesq);
            this.tabPeca.Controls.Add(this.groupBox2);
            this.tabPeca.Location = new System.Drawing.Point(4, 22);
            this.tabPeca.Name = "tabPeca";
            this.tabPeca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeca.Size = new System.Drawing.Size(1007, 610);
            this.tabPeca.TabIndex = 0;
            this.tabPeca.Text = "Consulta de Peças";
            this.tabPeca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(4, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 489);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisa.Location = new System.Drawing.Point(3, 16);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(989, 470);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPesquisa_CellFormatting);
            // 
            // txtPesq
            // 
            this.txtPesq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesq.Location = new System.Drawing.Point(120, 31);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(749, 20);
            this.txtPesq.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.mskFiltro);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbSVO);
            this.groupBox3.Location = new System.Drawing.Point(11, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 41);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros Filtros";
            // 
            // ckbSVO
            // 
            this.ckbSVO.AutoSize = true;
            this.ckbSVO.Location = new System.Drawing.Point(6, 19);
            this.ckbSVO.Name = "ckbSVO";
            this.ckbSVO.Size = new System.Drawing.Size(104, 17);
            this.ckbSVO.TabIndex = 41;
            this.ckbSVO.Text = "Pedido em SVO.";
            this.ckbSVO.UseVisualStyleBackColor = true;
            this.ckbSVO.Click += new System.EventHandler(this.ckbSVO_Click);
            // 
            // mskFiltro
            // 
            this.mskFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mskFiltro.FormattingEnabled = true;
            this.mskFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "DESCRIÇÃO",
            "CLIENTE"});
            this.mskFiltro.Location = new System.Drawing.Point(11, 24);
            this.mskFiltro.Name = "mskFiltro";
            this.mskFiltro.Size = new System.Drawing.Size(97, 21);
            this.mskFiltro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(869, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPecasVendidas
            // 
            this.tabPecasVendidas.Controls.Add(this.groupBox4);
            this.tabPecasVendidas.Controls.Add(this.groupBox5);
            this.tabPecasVendidas.Location = new System.Drawing.Point(4, 22);
            this.tabPecasVendidas.Name = "tabPecasVendidas";
            this.tabPecasVendidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPecasVendidas.Size = new System.Drawing.Size(1007, 610);
            this.tabPecasVendidas.TabIndex = 1;
            this.tabPecasVendidas.Text = "Consulta de Peças Vendidas";
            this.tabPecasVendidas.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPecasVendidas);
            this.groupBox4.Location = new System.Drawing.Point(6, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(995, 521);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // dgvPecasVendidas
            // 
            this.dgvPecasVendidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPecasVendidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPecasVendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecasVendidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPecasVendidas.Location = new System.Drawing.Point(3, 16);
            this.dgvPecasVendidas.Name = "dgvPecasVendidas";
            this.dgvPecasVendidas.ReadOnly = true;
            this.dgvPecasVendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecasVendidas.Size = new System.Drawing.Size(989, 502);
            this.dgvPecasVendidas.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPesqPecasVend);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(990, 67);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pesquisa";
            // 
            // txtPesqPecasVend
            // 
            this.txtPesqPecasVend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesqPecasVend.Location = new System.Drawing.Point(17, 25);
            this.txtPesqPecasVend.Name = "txtPesqPecasVend";
            this.txtPesqPecasVend.Size = new System.Drawing.Size(846, 20);
            this.txtPesqPecasVend.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(869, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pesquisar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.groupBox6);
            this.tabCliente.Controls.Add(this.groupBox7);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(1007, 610);
            this.tabCliente.TabIndex = 2;
            this.tabCliente.Text = "Consulta de Clientes";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvPesqCli);
            this.groupBox6.Location = new System.Drawing.Point(6, 99);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(995, 503);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            // 
            // dgvPesqCli
            // 
            this.dgvPesqCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPesqCli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPesqCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqCli.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPesqCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesqCli.Location = new System.Drawing.Point(3, 16);
            this.dgvPesqCli.Name = "dgvPesqCli";
            this.dgvPesqCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesqCli.Size = new System.Drawing.Size(989, 484);
            this.dgvPesqCli.TabIndex = 0;
            this.dgvPesqCli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPesqCli_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderPeçaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
            // 
            // venderPeçaToolStripMenuItem
            // 
            this.venderPeçaToolStripMenuItem.Name = "venderPeçaToolStripMenuItem";
            this.venderPeçaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.venderPeçaToolStripMenuItem.Text = "Vender Peça";
            this.venderPeçaToolStripMenuItem.Click += new System.EventHandler(this.venderPeçaToolStripMenuItem_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btNovoCliente);
            this.groupBox7.Controls.Add(this.txtPesqCli);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(8, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(990, 85);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pesquisa";
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.Location = new System.Drawing.Point(17, 56);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(139, 23);
            this.btNovoCliente.TabIndex = 49;
            this.btNovoCliente.Text = "Novo cliente/Alterar";
            this.btNovoCliente.UseVisualStyleBackColor = true;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
            // 
            // txtPesqCli
            // 
            this.txtPesqCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesqCli.Location = new System.Drawing.Point(17, 25);
            this.txtPesqCli.Name = "txtPesqCli";
            this.txtPesqCli.Size = new System.Drawing.Size(846, 20);
            this.txtPesqCli.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(869, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pesquisar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 658);
            this.Controls.Add(this.tbConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsulta_KeyDown);
            this.tbConsulta.ResumeLayout(false);
            this.tabPeca.ResumeLayout(false);
            this.tabPeca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPecasVendidas.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasVendidas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabCliente.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqCli)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbConsulta;
        private System.Windows.Forms.TabPage tabPeca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbSVO;
        protected System.Windows.Forms.ComboBox mskFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPecasVendidas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPecasVendidas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPesqPecasVend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvPesqCli;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtPesqCli;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btNovoCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem venderPeçaToolStripMenuItem;
    }
}