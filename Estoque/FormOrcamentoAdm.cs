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
    public partial class FormOrcamentoAdm : Form
    {
        int linha;
        int id;
        public FormOrcamentoAdm()
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
            habilitarBt(false, false, false, false);
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
                    if (or.F_STATUS == "C")
                    {
                        or.F_STATUS = "F";
                        or.DATA_ALT = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                        db.Entry(or).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Orçamento finalizado com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                        gbDetalhes.Enabled = false;
                        carregarDgv();
                        habilitarBt(true, false, false, false);
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
            habilitarBt(true, false, false, false);
            gbDetalhes.Enabled = false;
            limparCampos();
            carregarDgv();
        }
        PesqGeral pesq = new PesqGeral();
        private void btPesqCli_Click(object sender, EventArgs e)
        {

            pesq.Load += pesqDiag2_Load;
            pesq.btPesqDoc.Click += btPDiag2_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDCliente, txtDescCliente, pesq.retornoID, pesq.retornoDesc);

        }

        private void pesqDiag2_Load(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                pesq.dgvPesq.DataSource = db.cliente.Select(d => new
                {
                    ID = d.ID,
                    NOME = d.NOME,
                    CPF = d.CPF,
                    CIDADE = d.CIDADE,
                    ENDEREÇO = d.ENDERECO + " Nº " + d.NUMERO_CASA
                }).ToList();
            }
        }
        private void btPDiag2_Click(object sender, EventArgs e)
        {
            dbSgc db = new dbSgc();
            pesq.dgvPesq.DataSource = pesquisarCliente(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object pesquisarCliente(string pesquisa)
        {
            dbSgc db = new dbSgc();

            return db.cliente.Where(d => d.CPF.Contains(pesquisa) || d.NOME.ToString().Contains(pesquisa)).Select(d => new
            {
                ID = d.ID,
                NOME = d.NOME,
                CPF = d.CPF,
                CIDADE = d.CIDADE,
                ENDEREÇO = d.ENDERECO + " Nº " + d.NUMERO_CASA
            }).ToList();
        }

        private void preencheCampos(object sender1, object sender2, string ID, string Desc)
        {
            TextBox tID = sender1 as TextBox;
            if (!string.IsNullOrWhiteSpace(ID))
                tID.Text = ID;
            tID.BackColor = Color.White;


            TextBox tDesc = sender2 as TextBox;
            if (!string.IsNullOrWhiteSpace(Desc))
                tDesc.Text = Desc;


        }



        private void habilitarBt(bool novo, bool gravar, bool alterar, bool cancelar)
        {
            btNovo.Enabled = novo;
            btGravar.Enabled = gravar;
            btCancelar.Enabled = cancelar;
            btAlterar.Enabled = alterar;
        }

        private void FormOrcamentoAdm_Load(object sender, EventArgs e)
        {
            habilitarBt(true, false, false, false);
            carregarDgv();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    orcamentos or = new orcamentos();

                    or.F_STATUS = "C";
                    or.DATA_CRIACAO = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                    or.IDCLIENTE = Convert.ToInt32(txtIDCliente.Text);
                    or.PRODUTO = txtProdutoN.Text;
                    or.VALOR = txtValorN.Text;
                    or.OBSERVACAO = rtbObservacaoN.Text;
                    db.Entry(or).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    MessageBox.Show("Orçamento criado com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCamposN();
                    gbNovo.Enabled = false;
                    tbOrcamento.SelectTab(tabConsulta);
                    carregarDgv();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            tbOrcamento.SelectTab(tabNovo);
            habilitarBt(false, true, false, true);
            gbNovo.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbOrcamento.SelectTab(tabConsulta);
                gbNovo.Enabled = false;
                limparCamposN();
                habilitarBt(true, false, false, false);
                carregarDgv();
            }
        }

        private void limparCamposN()
        {
            txtIDCliente.Clear();
            txtDescCliente.Clear();
            txtProdutoN.Clear();
            txtValorN.Clear();
            rtbObservacaoN.Clear();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                tbOrcamento.SelectTab(tabNovo);
                gbNovo.Enabled = true;
                habilitarBt(true, false, false, false);
                using (var db = new dbSgc())
                {
                    orcamentos or = db.orcamentos.Find(id);

                    or.F_STATUS = "C";
                    or.DATA_CRIACAO = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                    or.IDCLIENTE = Convert.ToInt32(txtIDCliente.Text);
                    or.PRODUTO = txtProdutoN.Text;
                    or.VALOR = txtValorN.Text;
                    or.OBSERVACAO = rtbObservacaoN.Text;
                    db.Entry(or).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Orçamento alterado com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCamposN();
                    gbNovo.Enabled = false;
                    tbOrcamento.SelectTab(tabConsulta);
                    carregarDgv();


                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAlt_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    orcamentos or = db.orcamentos.Find(id);
                    if (or.F_STATUS == "C")
                    {
                        gbNovo.Enabled = true;
                        tbOrcamento.SelectTab(tabNovo);
                        habilitarBt(false, false, true, true);
                        txtIDCliente.Text = Convert.ToString(or.cliente.ID);
                        txtDescCliente.Text = or.cliente.NOME;
                        txtProdutoN.Text = or.PRODUTO;
                        txtValorN.Text = or.VALOR;
                        rtbObservacaoN.Text = or.OBSERVACAO;
                        gbDetalhes.Enabled = false;
                        limparCampos();
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

        private void dgvConsulta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && Convert.ToString(e.Value) == "V")
            {
                dgvConsulta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
            if (e.ColumnIndex == 7 && Convert.ToString(e.Value) == "F")
            {
                dgvConsulta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            if (e.ColumnIndex == 7 && Convert.ToString(e.Value) == "C") 
            {
                dgvConsulta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }

            
        }

        private void FormOrcamentoAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}

