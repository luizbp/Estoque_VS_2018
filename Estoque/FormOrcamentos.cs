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

    public partial class FormOrcamentos : Form
    {
        int linha;
        int id;
        public FormOrcamentos()
        {
            InitializeComponent();
        }

        private void FormOrcamentos_Load(object sender, EventArgs e)
        {
            carregarDgv();
        }

        private void carregarDgv()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvConsulta.DataSource = db.orcamentos.Select(d => new
                    {
                        ID = d.ID,
                        NOME = d.cliente.NOME,
                        CPF = d.cliente.CPF,
                        PRODUTO = d.PRODUTO,
                        DESCRIÇÃO = d.OBSERVACAO,
                        VALOR = d.VALOR,
                        IDCLIENTE = d.cliente.ID,
                        STATUS = d.F_STATUS

                    }).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvConsulta.RowCount > 0)
                {
                    linha = Convert.ToInt32(dgvConsulta.CurrentCell.RowIndex);
                    id = Convert.ToInt32(dgvConsulta.Rows[linha].Cells[0].Value);
                    gbDetalhes.Enabled = true;
                    using (var db = new dbSgc())
                    {
                        orcamentos or = db.orcamentos.Find(id);
                        txtNome.Text = or.cliente.NOME;
                        txtProduto.Text = or.PRODUTO;
                        if (or.F_STATUS == "C")
                            txtStatus.Text = "Criado";
                        else if (or.F_STATUS == "F")
                            txtStatus.Text = "Finalizado";
                        else if (or.F_STATUS == "V")
                            txtStatus.Text = "Visto";
                        mskDataEsp.Text = or.DATA_CRIACAO;
                        txtValor.Text = or.VALOR;
                        rtbObservacao.Text = or.OBSERVACAO;
                        mskDataConc.Text = or.DATA_ALT;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvConsulta.DataSource = db.orcamentos.Where(d => d.cliente.NOME.Contains(txtPesqConsulta.Text) ||
                        d.cliente.CPF.Contains(txtPesqConsulta.Text)).Select(d => new
                        {
                            ID = d.ID,
                            NOME = d.cliente.NOME,
                            CPF = d.cliente.CPF,
                            PRODUTO = d.PRODUTO,
                            DESCRIÇÃO = d.OBSERVACAO,
                            VALOR = d.VALOR,
                            IDCLIENTE = d.cliente.ID,
                            STATUS = d.F_STATUS

                        }).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvConsulta.RowCount > 1)
            {
                linha = Convert.ToInt32(dgvConsulta.CurrentCell.RowIndex);
                id = Convert.ToInt32(dgvConsulta.Rows[linha].Cells[0].Value);
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    orcamentos or = db.orcamentos.Find(id);
                    if (or.F_STATUS != "F")
                    {
                        or.F_STATUS = "F";
                        or.DATA_ALT = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                        db.Entry(or).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Orçamento finalizado com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                        gbDetalhes.Enabled = false;
                        carregarDgv();
                    }
                    else
                    {
                        MessageBox.Show("Orçameto já foi finalizado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtPesqConsulta.Clear();
            txtProduto.Clear();
            txtStatus.Clear();
            txtValor.Clear();
            mskDataConc.Clear();
            mskDataEsp.Clear();
            rtbObservacao.Text = "";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            gbDetalhes.Enabled = false;
            limparCampos();
            carregarDgv();
        }
    }
}
