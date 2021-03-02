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
    public partial class FormCadCliente : Form
    {
        int idAlt;
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {
            cbTipoCpf.Text = "CPF";
            carregarDgv();
            timer1.Start();
            habilitarBt(true, false, false, false);
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPesquisa.DataSource = db.cliente.Where(d => d.NOME.Contains(txtPesq.Text) || d.CPF.Contains(txtPesq.Text)).Select(d => new
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

        private void carregarDgv()
        {
            try
            {

                using (var db = new dbSgc())
                {
                    dgvPesquisa.DataSource = db.cliente.Select(d => new
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

        private void btNovo_Click(object sender, EventArgs e)
        {
            tbCad.SelectTab(tabCad);
            gbCad.Enabled = true;
            txtNome.Focus();
            habilitarBt(false, true, false, true);
        }

        private void habilitarBt(bool novo, bool gravar, bool alterar, bool cancelar)
        {
            btNovo.Enabled = novo;
            btGravar.Enabled = gravar;
            btCancelar.Enabled = cancelar;
            btAlterar.Enabled = alterar;
        }

        private void limparCampos()
        {
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            mskCelular.Clear();
            mskCpf.Clear();
            mskTelefone.Clear();
            rtbAdicionais.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbCad.SelectTab(tabPesq);
                gbCad.Enabled = false;
                limparCampos();
                habilitarBt(true, false, false, false);
                carregarDgv();
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (verifica() == true)
            {
                try
                {
                    using (var db = new dbSgc())
                    {

                        cliente cli = new cliente();
                        cli.NOME = txtNome.Text;
                        cli.CIDADE = txtCidade.Text;
                        cli.CPF = mskCpf.Text;
                        cli.ENDERECO = txtEndereco.Text;
                        cli.CELULAR = mskCelular.Text;
                        cli.TELEFONE = mskTelefone.Text;
                        cli.ADICIONAIS = rtbAdicionais.Text;
                        cli.NUMERO_CASA = txtNumero.Text;
                        db.Entry(cli).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        MessageBox.Show("Cliente cadastrado com sucesso!! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbCad.SelectTab(tabPesq);
                        gbCad.Enabled = false;
                        limparCampos();
                        habilitarBt(true, false, false, false);
                        carregarDgv();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool verifica()
        {
            if (txtNome.Text != String.Empty && txtNumero.Text != String.Empty && txtCidade.Text != String.Empty &&
                txtEndereco.Text != String.Empty && mskCpf.Text != String.Empty && mskCelular.Text != String.Empty)
            {
                return true;
            }
            else return false;
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {

                    int linha = Convert.ToInt32(dgvPesquisa.CurrentCell.RowIndex);
                    idAlt = Convert.ToInt32(dgvPesquisa[0, linha].Value);

                    cliente cli = db.cliente.Find(idAlt);
                    gbCad.Enabled = true;
                    txtNome.Text = cli.NOME;
                    txtNumero.Text = Convert.ToString(cli.NUMERO_CASA);
                    txtCidade.Text = cli.CIDADE;
                    txtEndereco.Text = cli.ENDERECO;
                    mskCelular.Text = cli.CELULAR;
                    mskTelefone.Text = cli.TELEFONE;
                    mskCpf.Text = cli.CPF;
                    rtbAdicionais.Text = cli.ADICIONAIS;
                    tbCad.SelectTab(tabCad);
                    txtNome.Focus();
                    habilitarBt(false, false, true, true);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (verifica() == true)
            {
                try
                {
                    using (var db = new dbSgc())
                    {

                        cliente cli = db.cliente.Find(idAlt);
                        cli.NOME = txtNome.Text;
                        cli.CIDADE = txtCidade.Text;
                        cli.CPF = mskCpf.Text;
                        cli.ENDERECO = txtEndereco.Text;
                        cli.CELULAR = mskCelular.Text;
                        cli.TELEFONE = mskTelefone.Text;
                        cli.ADICIONAIS = rtbAdicionais.Text;
                        cli.NUMERO_CASA = txtNumero.Text;
                        db.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Cliente alterado com sucesso!! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbCad.SelectTab(tabPesq);
                        gbCad.Enabled = false;
                        limparCampos();
                        habilitarBt(true, false, false, false);
                        carregarDgv();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTipoCpf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoCpf.Text == "CPF")
            {
                mskCpf.Clear();
                mskCpf.Mask = "000.000.000-00";
            }
            else
            {
                mskCpf.Clear();
                mskCpf.Mask = "00.000.000/0000-00";
            }
        }

        private void mskCpf_Click(object sender, EventArgs e)
        {
            mskCpf.SelectAll();
        }

        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.SelectAll();
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            mskCelular.SelectAll();
        }

        private void FormCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btPesq_Click(sender, e);
            }
        }
    }
}
