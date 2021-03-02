namespace Estoque
{
    partial class FormOrcamentoAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrcamentoAdm));
            this.tbOrcamento = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.rtbObservacao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btAlt = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDataConc = new System.Windows.Forms.MaskedTextBox();
            this.mskDataEsp = new System.Windows.Forms.MaskedTextBox();
            this.gbPesq = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesqConsulta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.tabNovo = new System.Windows.Forms.TabPage();
            this.gbNovo = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btPesq = new System.Windows.Forms.Button();
            this.rtbObservacaoN = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescCliente = new System.Windows.Forms.TextBox();
            this.txtProdutoN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtValorN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.tbOrcamento.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.gbDetalhes.SuspendLayout();
            this.gbPesq.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tabNovo.SuspendLayout();
            this.gbNovo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOrcamento
            // 
            this.tbOrcamento.Controls.Add(this.tabConsulta);
            this.tbOrcamento.Controls.Add(this.tabNovo);
            this.tbOrcamento.Location = new System.Drawing.Point(7, 63);
            this.tbOrcamento.Name = "tbOrcamento";
            this.tbOrcamento.SelectedIndex = 0;
            this.tbOrcamento.Size = new System.Drawing.Size(1032, 650);
            this.tbOrcamento.TabIndex = 0;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.gbDetalhes);
            this.tabConsulta.Controls.Add(this.gbPesq);
            this.tabConsulta.Controls.Add(this.groupBox2);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(1024, 624);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.rtbObservacao);
            this.gbDetalhes.Controls.Add(this.label5);
            this.gbDetalhes.Controls.Add(this.txtNome);
            this.gbDetalhes.Controls.Add(this.btAlt);
            this.gbDetalhes.Controls.Add(this.btFinalizar);
            this.gbDetalhes.Controls.Add(this.btOK);
            this.gbDetalhes.Controls.Add(this.txtProduto);
            this.gbDetalhes.Controls.Add(this.label2);
            this.gbDetalhes.Controls.Add(this.lbMotivo);
            this.gbDetalhes.Controls.Add(this.txtValor);
            this.gbDetalhes.Controls.Add(this.label6);
            this.gbDetalhes.Controls.Add(this.txtStatus);
            this.gbDetalhes.Controls.Add(this.label4);
            this.gbDetalhes.Controls.Add(this.label7);
            this.gbDetalhes.Controls.Add(this.label3);
            this.gbDetalhes.Controls.Add(this.mskDataConc);
            this.gbDetalhes.Controls.Add(this.mskDataEsp);
            this.gbDetalhes.Enabled = false;
            this.gbDetalhes.Location = new System.Drawing.Point(6, 452);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(1003, 162);
            this.gbDetalhes.TabIndex = 14;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes";
            // 
            // rtbObservacao
            // 
            this.rtbObservacao.Location = new System.Drawing.Point(412, 68);
            this.rtbObservacao.Name = "rtbObservacao";
            this.rtbObservacao.ReadOnly = true;
            this.rtbObservacao.Size = new System.Drawing.Size(480, 87);
            this.rtbObservacao.TabIndex = 9;
            this.rtbObservacao.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(469, 20);
            this.txtNome.TabIndex = 7;
            // 
            // btAlt
            // 
            this.btAlt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlt.ForeColor = System.Drawing.Color.Black;
            this.btAlt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlt.Location = new System.Drawing.Point(898, 123);
            this.btAlt.Name = "btAlt";
            this.btAlt.Size = new System.Drawing.Size(99, 32);
            this.btAlt.TabIndex = 3;
            this.btAlt.Text = "Alterar Orça.";
            this.btAlt.UseVisualStyleBackColor = true;
            this.btAlt.Click += new System.EventHandler(this.btAlt_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFinalizar.Location = new System.Drawing.Point(898, 85);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(99, 32);
            this.btFinalizar.TabIndex = 3;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.Black;
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOK.Location = new System.Drawing.Point(898, 45);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(99, 32);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(63, 45);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(340, 20);
            this.txtProduto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observação:";
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.Location = new System.Drawing.Point(17, 48);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(47, 13);
            this.lbMotivo.TabIndex = 5;
            this.lbMotivo.Text = "Produto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(63, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(90, 20);
            this.txtValor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(63, 71);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(165, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Conclusão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // mskDataConc
            // 
            this.mskDataConc.Location = new System.Drawing.Point(797, 19);
            this.mskDataConc.Mask = "00/00/0000";
            this.mskDataConc.Name = "mskDataConc";
            this.mskDataConc.ReadOnly = true;
            this.mskDataConc.Size = new System.Drawing.Size(124, 20);
            this.mskDataConc.TabIndex = 3;
            // 
            // mskDataEsp
            // 
            this.mskDataEsp.Location = new System.Drawing.Point(573, 19);
            this.mskDataEsp.Mask = "00/00/0000";
            this.mskDataEsp.Name = "mskDataEsp";
            this.mskDataEsp.ReadOnly = true;
            this.mskDataEsp.Size = new System.Drawing.Size(124, 20);
            this.mskDataEsp.TabIndex = 3;
            // 
            // gbPesq
            // 
            this.gbPesq.Controls.Add(this.button1);
            this.gbPesq.Controls.Add(this.label1);
            this.gbPesq.Controls.Add(this.txtPesqConsulta);
            this.gbPesq.Location = new System.Drawing.Point(6, 6);
            this.gbPesq.Name = "gbPesq";
            this.gbPesq.Size = new System.Drawing.Size(1015, 91);
            this.gbPesq.TabIndex = 12;
            this.gbPesq.TabStop = false;
            this.gbPesq.Text = "Pesquisa";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(891, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPesqConsulta
            // 
            this.txtPesqConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesqConsulta.Location = new System.Drawing.Point(63, 36);
            this.txtPesqConsulta.Name = "txtPesqConsulta";
            this.txtPesqConsulta.Size = new System.Drawing.Size(822, 20);
            this.txtPesqConsulta.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvConsulta);
            this.groupBox2.Location = new System.Drawing.Point(6, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 343);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orçamentos em Abertos";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 16);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(1009, 324);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            this.dgvConsulta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvConsulta_CellFormatting);
            // 
            // tabNovo
            // 
            this.tabNovo.Controls.Add(this.gbNovo);
            this.tabNovo.Location = new System.Drawing.Point(4, 22);
            this.tabNovo.Name = "tabNovo";
            this.tabNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovo.Size = new System.Drawing.Size(1024, 624);
            this.tabNovo.TabIndex = 1;
            this.tabNovo.Text = "Novo";
            this.tabNovo.UseVisualStyleBackColor = true;
            // 
            // gbNovo
            // 
            this.gbNovo.Controls.Add(this.btClear);
            this.gbNovo.Controls.Add(this.btPesq);
            this.gbNovo.Controls.Add(this.rtbObservacaoN);
            this.gbNovo.Controls.Add(this.label8);
            this.gbNovo.Controls.Add(this.txtDescCliente);
            this.gbNovo.Controls.Add(this.txtProdutoN);
            this.gbNovo.Controls.Add(this.label9);
            this.gbNovo.Controls.Add(this.label10);
            this.gbNovo.Controls.Add(this.txtIDCliente);
            this.gbNovo.Controls.Add(this.txtValorN);
            this.gbNovo.Controls.Add(this.label11);
            this.gbNovo.Enabled = false;
            this.gbNovo.Location = new System.Drawing.Point(6, 6);
            this.gbNovo.Name = "gbNovo";
            this.gbNovo.Size = new System.Drawing.Size(997, 263);
            this.gbNovo.TabIndex = 15;
            this.gbNovo.TabStop = false;
            this.gbNovo.Text = "Detalhes";
            // 
            // btClear
            // 
            this.btClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClear.BackgroundImage")));
            this.btClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Location = new System.Drawing.Point(558, 11);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(35, 34);
            this.btClear.TabIndex = 48;
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btPesq
            // 
            this.btPesq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesq.BackgroundImage")));
            this.btPesq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesq.FlatAppearance.BorderSize = 0;
            this.btPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesq.Location = new System.Drawing.Point(599, 11);
            this.btPesq.Name = "btPesq";
            this.btPesq.Size = new System.Drawing.Size(35, 34);
            this.btPesq.TabIndex = 49;
            this.btPesq.UseVisualStyleBackColor = true;
            this.btPesq.Click += new System.EventHandler(this.btPesqCli_Click);
            // 
            // rtbObservacaoN
            // 
            this.rtbObservacaoN.Location = new System.Drawing.Point(14, 112);
            this.rtbObservacaoN.Name = "rtbObservacaoN";
            this.rtbObservacaoN.Size = new System.Drawing.Size(480, 87);
            this.rtbObservacaoN.TabIndex = 9;
            this.rtbObservacaoN.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cliente:";
            // 
            // txtDescCliente
            // 
            this.txtDescCliente.Location = new System.Drawing.Point(124, 19);
            this.txtDescCliente.Name = "txtDescCliente";
            this.txtDescCliente.ReadOnly = true;
            this.txtDescCliente.Size = new System.Drawing.Size(430, 20);
            this.txtDescCliente.TabIndex = 7;
            // 
            // txtProdutoN
            // 
            this.txtProdutoN.Location = new System.Drawing.Point(57, 45);
            this.txtProdutoN.Name = "txtProdutoN";
            this.txtProdutoN.Size = new System.Drawing.Size(495, 20);
            this.txtProdutoN.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Observação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Produto:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(57, 19);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(63, 20);
            this.txtIDCliente.TabIndex = 6;
            // 
            // txtValorN
            // 
            this.txtValorN.Location = new System.Drawing.Point(57, 73);
            this.txtValorN.Name = "txtValorN";
            this.txtValorN.Size = new System.Drawing.Size(90, 20);
            this.txtValorN.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Valor:";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(370, 12);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 41);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGravar.Location = new System.Drawing.Point(128, 12);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(115, 41);
            this.btGravar.TabIndex = 13;
            this.btGravar.Text = "Gravar";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(249, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(115, 41);
            this.btAlterar.TabIndex = 14;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(7, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(115, 41);
            this.btNovo.TabIndex = 12;
            this.btNovo.Text = "Novo";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormOrcamentoAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 721);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.tbOrcamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormOrcamentoAdm";
            this.Text = "FormOrcamentoAdm";
            this.Load += new System.EventHandler(this.FormOrcamentoAdm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOrcamentoAdm_KeyDown);
            this.tbOrcamento.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.gbPesq.ResumeLayout(false);
            this.gbPesq.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tabNovo.ResumeLayout(false);
            this.gbNovo.ResumeLayout(false);
            this.gbNovo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbOrcamento;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabNovo;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.RichTextBox rtbObservacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDataConc;
        private System.Windows.Forms.MaskedTextBox mskDataEsp;
        private System.Windows.Forms.GroupBox gbPesq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesqConsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.GroupBox gbNovo;
        private System.Windows.Forms.RichTextBox rtbObservacaoN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescCliente;
        private System.Windows.Forms.TextBox txtProdutoN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtValorN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btAlt;
    }
}