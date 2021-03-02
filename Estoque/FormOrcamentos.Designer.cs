namespace Estoque
{
    partial class FormOrcamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrcamentos));
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.rtbObservacao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
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
            this.gbDetalhes.SuspendLayout();
            this.gbPesq.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.rtbObservacao);
            this.gbDetalhes.Controls.Add(this.label5);
            this.gbDetalhes.Controls.Add(this.txtNome);
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
            this.gbDetalhes.Location = new System.Drawing.Point(9, 546);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(1003, 162);
            this.gbDetalhes.TabIndex = 11;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes";
            // 
            // rtbObservacao
            // 
            this.rtbObservacao.Location = new System.Drawing.Point(289, 59);
            this.rtbObservacao.Name = "rtbObservacao";
            this.rtbObservacao.ReadOnly = true;
            this.rtbObservacao.Size = new System.Drawing.Size(480, 87);
            this.rtbObservacao.TabIndex = 9;
            this.rtbObservacao.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(430, 20);
            this.txtNome.TabIndex = 7;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFinalizar.Location = new System.Drawing.Point(898, 124);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(99, 32);
            this.btFinalizar.TabIndex = 3;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.Black;
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOK.Location = new System.Drawing.Point(793, 124);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(99, 32);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(103, 45);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(165, 20);
            this.txtProduto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observação:";
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.Location = new System.Drawing.Point(57, 48);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(47, 13);
            this.lbMotivo.TabIndex = 5;
            this.lbMotivo.Text = "Produto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(103, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(90, 20);
            this.txtValor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(103, 71);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(165, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 74);
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
            this.gbPesq.Location = new System.Drawing.Point(6, 12);
            this.gbPesq.Name = "gbPesq";
            this.gbPesq.Size = new System.Drawing.Size(1015, 91);
            this.gbPesq.TabIndex = 9;
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
            this.groupBox2.Location = new System.Drawing.Point(6, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 431);
            this.groupBox2.TabIndex = 10;
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
            this.dgvConsulta.Size = new System.Drawing.Size(1009, 412);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            this.dgvConsulta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvConsulta_MouseDown);
            // 
            // FormOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 720);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.gbPesq);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrcamentos";
            this.Text = "Orçamentos";
            this.Load += new System.EventHandler(this.FormOrcamentos_Load);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.gbPesq.ResumeLayout(false);
            this.gbPesq.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDataEsp;
        private System.Windows.Forms.GroupBox gbPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesqConsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskDataConc;
        private System.Windows.Forms.Button btFinalizar;
    }
}