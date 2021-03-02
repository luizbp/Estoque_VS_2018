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
    public partial class FormSaida : Form
    {
        double AcPreco = 0;
        int Linha = 0;
        int idpeca;
        int ID;
        string NOME;
        public FormSaida(int id, string nome)
        {
            InitializeComponent();
            ID = id;
            NOME = nome;
        }

        PesqGeral pesq = new PesqGeral();
        private void btPesqCliente_Click(object sender, EventArgs e)
        {

            pesq.Load += pesqDiag_Load;
            pesq.btPesqDoc.Click += btPDiag_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDPeca, txtDescPeca, pesq.retornoID, pesq.retornoDesc);

        }

        private void pesqDiag_Load(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                pesq.dgvPesq.DataSource = db.pecas.Select(d => new
                {
                    ID = d.ID,
                    DESCRIÇÃO = d.DESCRICAO,
                    CODIGO = d.CODIGO,
                    TIPO = d.TIPO,
                    PRATELEIRA = d.PRATELEIRA,
                    QUANTIDADE = d.QTDE,
                    PREÇO = "R$ " + d.PRECO,
                    CLIENTE = d.cliente.NOME,
                    SVO = d.PE_SVO
                }).OrderByDescending(d => d.QUANTIDADE).ToList();
            }
        }
        private void btPDiag_Click(object sender, EventArgs e)
        {
            dbSgc db = new dbSgc();
            pesq.dgvPesq.DataSource = pesquisarAluno(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object pesquisarAluno(string pesquisa)
        {
            dbSgc db = new dbSgc();

            return db.pecas.Where(d => d.DESCRICAO.Contains(pesquisa) || d.CODIGO.ToString().Contains(pesquisa)).Select(d => new
            {
                ID = d.ID,
                DESCRIÇÃO = d.DESCRICAO,
                CODIGO = d.CODIGO,
                TIPO = d.TIPO,
                PRATELEIRA = d.PRATELEIRA,
                QUANTIDADE = d.QTDE,
                PREÇO = "R$ " + d.PRECO,
                CLIENTE = d.cliente.NOME,
                SVO = d.PE_SVO

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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtIDPeca.Text != String.Empty && txtQuant.Text != String.Empty)
            {

                try
                {
                    using (var db = new dbSgc())
                    {
                        pecas pe = db.pecas.Find(Convert.ToInt32(txtIDPeca.Text));
                        
                        idpeca = Convert.ToInt32(txtIDPeca.Text);
                        if (txtIDPeca.Text != string.Empty && txtDescPeca.Text != string.Empty && txtQuant.Text != string.Empty)
                        {
                            if (verificarEx(Convert.ToInt32(txtIDPeca.Text)) == false)
                            {
                                if (pe.QTDE < Convert.ToInt32(txtQuant.Text))
                                {
                                    MessageBox.Show("Quantidade insuficiente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtQuant.Focus();
                                    txtQuant.SelectAll();
                                }
                                else
                                {
                                    int qt = Convert.ToInt32(txtQuant.Text);
                                    pe.QTDE = pe.QTDE - qt;
                                    db.Entry(pe).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                    dgvPecas.Rows.Add(pe.ID, pe.CODIGO, txtDescPeca.Text, pe.TIPO, txtQuant.Text, pe.PRECO, pe.cliente.NOME);
                                    double preco = Convert.ToDouble(pe.PRECO);
                                    int qtde = Convert.ToInt32(txtQuant.Text);
                                    AcPreco = (qtde * preco) + AcPreco;
                                    lbTotal.Text = Convert.ToString(AcPreco);
                                    txtQuant.Clear();
                                    txtIDPeca.Clear();
                                    txtDescPeca.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Esta peça ja esta cadastrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FormSaida_Load(object sender, EventArgs e)
        {
            dgvPecas.Columns.Add("ID", "ID");
            dgvPecas.Columns.Add("Codigo", "Codigo");
            dgvPecas.Columns.Add("Descrição", "Descrição");
            dgvPecas.Columns.Add("Tipo", "Tipo");
            dgvPecas.Columns.Add("Quantidade", "Quantidade");
            dgvPecas.Columns.Add("Preco", "Preço");
            dgvPecas.Columns.Add("Cliente Peça", "Cliente Peça");
            txtIDCliente.Text = Convert.ToString(ID);
            txtDesqCliente.Text = NOME;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    pecas pe = db.pecas.Find(Convert.ToInt32(Convert.ToInt32(dgvPecas.Rows[Linha].Cells[0].Value)));
                    int qt = Convert.ToInt32(dgvPecas.Rows[Linha].Cells[4].Value);
                    pe.QTDE = pe.QTDE + qt;
                    db.Entry(pe).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    double valor = Convert.ToDouble(dgvPecas.Rows[Linha].Cells[5].Value);
                    int qtd = Convert.ToInt32(dgvPecas.Rows[Linha].Cells[4].Value);
                    double valorlinha = Convert.ToDouble(lbTotal.Text);
                    AcPreco = AcPreco - (qtd * valor);
                    lbTotal.Text = Convert.ToString(valorlinha - (qtd * valor));
                    dgvPecas.Rows.RemoveAt(Linha);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPecas_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvPecas.Rows.Count > 1)
                Linha = Convert.ToInt32(dgvPecas.CurrentCell.RowIndex);
        }

        private bool verificarEx(int id)
        {
            using (var db = new dbSgc())
            {
                pecas pe = db.pecas.Find(Convert.ToInt32(id));
                int count = 0;
                for (int op = 0; op <= dgvPecas.Rows.Count - 1; op++)
                {
                    if (pe.CODIGO == Convert.ToInt32(dgvPecas.Rows[op].Cells[0].Value))
                    {
                        count++;
                    }
                }
                if (count == 0)
                    return false;
                else return true;
            }
        }

        private void btPesqCli_Click(object sender, EventArgs e)
        {

            pesq.Load += pesqDiag2_Load;
            pesq.btPesqDoc.Click += btPDiag2_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDCliente, txtDesqCliente, pesq.retornoID, pesq.retornoDesc);

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

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDCliente.Text != String.Empty && txtDesqCliente.Text != String.Empty && dgvPecas.Rows.Count > 0)
                {
                    using (var db = new dbSgc())
                    {
                        pecas_vendidas pe = new pecas_vendidas();
                        
                        for (int op = 0; op <dgvPecas.RowCount - 1; op++)
                        {
                            pe.CODIGO = Convert.ToInt32(dgvPecas.Rows[op].Cells[1].Value);
                            pe.DESCRICAO = Convert.ToString(dgvPecas.Rows[op].Cells[2].Value);
                            pe.TIPO = Convert.ToString(dgvPecas.Rows[op].Cells[3].Value);
                            pe.QTDE = Convert.ToInt32(dgvPecas.Rows[op].Cells[4].Value);
                            pe.PRECO = Convert.ToString(dgvPecas.Rows[op].Cells[5].Value);
                            pe.IDCLIENTE = Convert.ToInt32(txtIDCliente.Text);
                            pe.DATA_VENDA = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                            db.Entry(pe).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                        }
                        MessageBox.Show("Cadastro realizado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPecas.Rows.Clear();
                        txtDesqCliente.Clear();
                        txtIDCliente.Clear();
                        lbTotal.Text = Convert.ToString(0);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados para cadastro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }catch(Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente ca = new FormCadCliente();
            ca.StartPosition = FormStartPosition.CenterScreen;
            ca.ShowDialog();
        }
    }
}
