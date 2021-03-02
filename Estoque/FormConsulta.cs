using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.Models;

namespace Estoque
{
    public partial class FormConsulta : Form
    {
        int IDAlt;
        int id;
        string nome;
        public FormConsulta()
        {
            InitializeComponent();
        }
        private void carregarDgvPecas()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPesquisa.DataSource = db.pecas.Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarDgvPecasVendidas()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPecasVendidas.DataSource = db.pecas_vendidas.Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        DATA_VENDA = d.DATA_VENDA
                    }).ToList();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carregarDgvCliente()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPesqCli.DataSource = db.cliente.Select(d => new
                    {
                        ID = d.ID,
                        NOME = d.NOME,
                        CPF = d.CPF,
                        CIDADE = d.CIDADE,
                        ENDEREÇO = d.ENDERECO + " N° " + d.NUMERO_CASA,
                        TELEFONE = d.TELEFONE,
                        CELULAR = d.CELULAR,
                        ADICIONAIS = d.ADICIONAIS
                    }).ToList();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            carregarDgvPecas();
            mskFiltro.Text = "CODIGO";
        }

        private void dgvPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && Convert.ToInt32(e.Value) >= 1)
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            if (e.ColumnIndex == 5 && Convert.ToInt32(e.Value) <= 0)
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }

            if (e.ColumnIndex == 5 && Convert.ToInt32(e.Value) == 0)
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                if (mskFiltro.Text == "DESCRIÇÃO" && ckbSVO.Checked)
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.DESCRICAO.Contains(txtPesq.Text) && d.PE_SVO == "S").Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
                else if (mskFiltro.Text == "DESCRIÇÃO")
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.DESCRICAO.Contains(txtPesq.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
                if (mskFiltro.Text == "CODIGO" && ckbSVO.Checked)
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.CODIGO.ToString().Contains(txtPesq.Text) && d.PE_SVO == "S").Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
                else if (mskFiltro.Text == "CODIGO")
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.CODIGO.ToString().Contains(txtPesq.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
                if (mskFiltro.Text == "CLIENTE" && ckbSVO.Checked)
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.cliente.NOME.Contains(txtPesq.Text) && d.PE_SVO == "S").Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
                else if (mskFiltro.Text == "CLIENTE")
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.cliente.NOME.Contains(txtPesq.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();
                }
            }
        }

        private void ckbSVO_Click(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                if (ckbSVO.Checked == true)
                {
                    dgvPesquisa.DataSource = db.pecas.Where(d => d.PE_SVO == "S").Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        PRATELEIRA = d.PRATELEIRA,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        SVO = d.PE_SVO
                    }).ToList();

                }
                if (ckbSVO.Checked == false)
                    carregarDgvPecas();
            }
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = Convert.ToInt32(dgvPesquisa.CurrentCell.RowIndex);
            IDAlt = Convert.ToInt32(dgvPesquisa[0, linha].Value);
            using (var db = new dbSgc())
            {

            }
        }

        private void tbConsulta_Click(object sender, EventArgs e)
        {
            if (tbConsulta.SelectedTab == tabPeca)
                carregarDgvPecas();
            if (tbConsulta.SelectedTab == tabPecasVendidas)
                carregarDgvPecasVendidas();
            if (tbConsulta.SelectedTab == tabCliente)
                carregarDgvCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPecasVendidas.DataSource = db.pecas_vendidas.Where(d => d.DESCRICAO.Contains(txtPesqPecasVend.Text) ||
                    d.CODIGO.ToString().Contains(txtPesqPecasVend.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        TIPO = d.TIPO,
                        QUANTIDADE = d.QTDE,
                        PREÇO = "R$ " + d.PRECO,
                        CLIENTE = d.cliente.NOME,
                        DATA_VENDA = d.DATA_VENDA
                    }).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPesqCli.DataSource = db.cliente.Where(d => d.NOME.Contains(txtPesqCli.Text) || d.CPF.Contains(txtPesqCli.Text)).Select(d => new
                    {
                        ID = d.ID,
                        NOME = d.NOME,
                        CPF = d.CPF,
                        CIDADE = d.CIDADE,
                        ENDEREÇO = d.ENDERECO + " N° " + d.NUMERO_CASA,
                        TELEFONE = d.TELEFONE,
                        CELULAR = d.CELULAR,
                        ADICIONAIS = d.ADICIONAIS
                    }).ToList();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente ca = new FormCadCliente();
            ca.StartPosition = FormStartPosition.CenterScreen;
            ca.ShowDialog();
            carregarDgvCliente();
        }

        private void venderPeçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPesqCli.RowCount > 1)
            {
                FormSaida fo = new FormSaida(id, nome);
                fo.WindowState = FormWindowState.Normal;
                fo.StartPosition = FormStartPosition.CenterParent;
                fo.ShowDialog();
            }
        }

        private void dgvPesqCli_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvPesqCli.RowCount > 1)
            {
                try
                {
                    int Linha = Convert.ToInt32(dgvPesqCli.CurrentCell.RowIndex);
                    id = Convert.ToInt32(dgvPesqCli[0, Linha].Value);
                    nome = Convert.ToString(dgvPesqCli[1, Linha].Value);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbConsulta.SelectedTab == tabPeca)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    button1_Click(sender, e);
                }
            }
            if (tbConsulta.SelectedTab == tabPecasVendidas)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button2_Click(sender, e);
                }
            }
            if (tbConsulta.SelectedTab == tabCliente)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button3_Click(sender, e);
                }
            }
        }
    }
}
