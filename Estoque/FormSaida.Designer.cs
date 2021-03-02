namespace Estoque
{
    partial class FormSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btClearPeca = new System.Windows.Forms.Button();
            this.btPesqPeca = new System.Windows.Forms.Button();
            this.txtDescPeca = new System.Windows.Forms.TextBox();
            this.txtIDPeca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.txtDesqCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.btClearCliente = new System.Windows.Forms.Button();
            this.btPesqCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.btClearPeca);
            this.groupBox1.Controls.Add(this.btPesqPeca);
            this.groupBox1.Controls.Add(this.txtDescPeca);
            this.groupBox1.Controls.Add(this.txtIDPeca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(622, 28);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 20);
            this.txtQuant.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(714, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(738, 397);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(16, 16);
            this.lbTotal.TabIndex = 49;
            this.lbTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(670, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Total:";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionar.BackgroundImage")));
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Location = new System.Drawing.Point(754, 20);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(35, 34);
            this.btAdicionar.TabIndex = 48;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btClearPeca
            // 
            this.btClearPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClearPeca.BackgroundImage")));
            this.btClearPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearPeca.FlatAppearance.BorderSize = 0;
            this.btClearPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearPeca.Location = new System.Drawing.Point(540, 20);
            this.btClearPeca.Name = "btClearPeca";
            this.btClearPeca.Size = new System.Drawing.Size(35, 34);
            this.btClearPeca.TabIndex = 46;
            this.btClearPeca.UseVisualStyleBackColor = true;
            // 
            // btPesqPeca
            // 
            this.btPesqPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqPeca.BackgroundImage")));
            this.btPesqPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqPeca.FlatAppearance.BorderSize = 0;
            this.btPesqPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqPeca.Location = new System.Drawing.Point(581, 20);
            this.btPesqPeca.Name = "btPesqPeca";
            this.btPesqPeca.Size = new System.Drawing.Size(35, 34);
            this.btPesqPeca.TabIndex = 47;
            this.btPesqPeca.UseVisualStyleBackColor = true;
            this.btPesqPeca.Click += new System.EventHandler(this.btPesqCliente_Click);
            // 
            // txtDescPeca
            // 
            this.txtDescPeca.Location = new System.Drawing.Point(86, 28);
            this.txtDescPeca.Name = "txtDescPeca";
            this.txtDescPeca.ReadOnly = true;
            this.txtDescPeca.Size = new System.Drawing.Size(448, 20);
            this.txtDescPeca.TabIndex = 44;
            // 
            // txtIDPeca
            // 
            this.txtIDPeca.Location = new System.Drawing.Point(10, 28);
            this.txtIDPeca.Name = "txtIDPeca";
            this.txtIDPeca.ReadOnly = true;
            this.txtIDPeca.Size = new System.Drawing.Size(70, 20);
            this.txtIDPeca.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Peça:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPecas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 321);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peças selecionadas";
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
            this.dgvPecas.Size = new System.Drawing.Size(778, 302);
            this.dgvPecas.TabIndex = 0;
            this.dgvPecas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPecas_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btFinalizar);
            this.groupBox3.Controls.Add(this.btNovoCliente);
            this.groupBox3.Controls.Add(this.txtDesqCliente);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtIDCliente);
            this.groupBox3.Controls.Add(this.btClearCliente);
            this.groupBox3.Controls.Add(this.btPesqCliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btFinalizar.Image")));
            this.btFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFinalizar.Location = new System.Drawing.Point(692, 77);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(97, 39);
            this.btFinalizar.TabIndex = 49;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.Location = new System.Drawing.Point(10, 98);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(108, 23);
            this.btNovoCliente.TabIndex = 48;
            this.btNovoCliente.Text = "Novo cliente";
            this.btNovoCliente.UseVisualStyleBackColor = true;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
            // 
            // txtDesqCliente
            // 
            this.txtDesqCliente.Location = new System.Drawing.Point(86, 36);
            this.txtDesqCliente.Name = "txtDesqCliente";
            this.txtDesqCliente.ReadOnly = true;
            this.txtDesqCliente.Size = new System.Drawing.Size(530, 20);
            this.txtDesqCliente.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(10, 36);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(70, 20);
            this.txtIDCliente.TabIndex = 45;
            // 
            // btClearCliente
            // 
            this.btClearCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClearCliente.BackgroundImage")));
            this.btClearCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearCliente.FlatAppearance.BorderSize = 0;
            this.btClearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearCliente.Location = new System.Drawing.Point(622, 28);
            this.btClearCliente.Name = "btClearCliente";
            this.btClearCliente.Size = new System.Drawing.Size(35, 34);
            this.btClearCliente.TabIndex = 46;
            this.btClearCliente.UseVisualStyleBackColor = true;
            // 
            // btPesqCliente
            // 
            this.btPesqCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqCliente.BackgroundImage")));
            this.btPesqCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqCliente.FlatAppearance.BorderSize = 0;
            this.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqCliente.Location = new System.Drawing.Point(663, 28);
            this.btPesqCliente.Name = "btPesqCliente";
            this.btPesqCliente.Size = new System.Drawing.Size(35, 34);
            this.btPesqCliente.TabIndex = 47;
            this.btPesqCliente.UseVisualStyleBackColor = true;
            this.btPesqCliente.Click += new System.EventHandler(this.btPesqCli_Click);
            // 
            // FormSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaida";
            this.Text = "Saida de Peças";
            this.Load += new System.EventHandler(this.FormSaida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.Button btClearPeca;
        private System.Windows.Forms.Button btPesqPeca;
        private System.Windows.Forms.TextBox txtDescPeca;
        private System.Windows.Forms.TextBox txtIDPeca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btNovoCliente;
        private System.Windows.Forms.TextBox txtDesqCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Button btClearCliente;
        private System.Windows.Forms.Button btPesqCliente;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}