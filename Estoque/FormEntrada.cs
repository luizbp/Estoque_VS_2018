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
    public partial class FormEntrada : Form
    {
        int Linha;
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            tmEntrada.Start();
            dgvPecas.Columns.Add("Codigo", "Codigo");
            dgvPecas.Columns.Add("Descrição", "Descrição");
            dgvPecas.Columns.Add("Tipo", "Tipo");
            dgvPecas.Columns.Add("Quantidade", "Quantidade");
            dgvPecas.Columns.Add("Preco", "Preço");
            dgvPecas.Columns.Add("ID Cliente", "ID Cliente");
            dgvPecas.Columns.Add("SVO", "SVO");

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string svo;
            if (ckbSVO.Checked == true)
                svo = "S";
            else svo = "N";

            if (verifica() == true)
            {
                dgvPecas.Rows.Add(txtCodigo.Text, txtDescricao.Text, cbTipo.Text, txtQuant.Text, txtValor.Text, txtIDCli.Text, svo);
                btCadastrar.Enabled = true;
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool verifica()
        {
            if (txtCodigo.Text != String.Empty && txtDescricao.Text != String.Empty && txtQuant.Text
                != String.Empty && cbTipo.Text != String.Empty && txtValor.Text != String.Empty)
            {
                return true;
            }
            else return false;
        }

        public void LimparCampos()
        {
            txtValor.Clear();
            txtQuant.Clear();
            txtDescricao.Clear();
            txtCodigo.Clear();
            cbTipo.Text = null;
            ckbSVO.Checked = false;
        }

        private void tmEntrada_Tick(object sender, EventArgs e)
        {
            
        }

        private void ckbPedEstoq_Click(object sender, EventArgs e)
        {
            if (ckbPedEstoq.Checked == true)
            {
                txtDescCli.Text = "MG BARRETOS";
                txtIDCli.Text = "1";
            }
            else
            {
                txtDescCli.Clear();
                txtIDCli.Clear();
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            int dgv = dgvPecas.RowCount;
            if (dgv > 1)
            {
                using (var db = new dbSgc())
                {
                    try
                    {
                        for (int op = 0; op < dgvPecas.RowCount -1; op++)
                        {
                            int codigo = Convert.ToInt32(dgvPecas.Rows[op].Cells[0].Value);
                            int count = db.pecas.Where(d => d.CODIGO == codigo).Count();
                            if (count > 0)
                            {
                                int idpeca = db.pecas.Where(d => d.CODIGO == codigo).FirstOrDefault().ID;
                                pecas pe = db.pecas.Find(idpeca);
                                pe.QTDE = Convert.ToInt32(dgvPecas.Rows[op].Cells[3].Value) + pe.QTDE;
                                db.Entry(pe).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();
                            }
                            else
                            {
                                pecas pe = new pecas();
                                pe.CODIGO = Convert.ToInt32(dgvPecas.Rows[op].Cells[0].Value);
                                pe.DESCRICAO = Convert.ToString(dgvPecas.Rows[op].Cells[1].Value);
                                pe.TIPO = Convert.ToString(dgvPecas.Rows[op].Cells[2].Value);
                                if (pe.TIPO == "REFRIGERADOR")
                                    pe.PRATELEIRA = "R";
                                else if (pe.TIPO == "LAVADORA")
                                    pe.PRATELEIRA = "L";
                                else if (pe.TIPO == "FREEZER")
                                    pe.PRATELEIRA = "F";
                                else if (pe.TIPO == "PURIFICADOR")
                                    pe.PRATELEIRA = "P";
                                else if (pe.TIPO == "FORNO")
                                    pe.PRATELEIRA = "F";
                                else if (pe.TIPO == "FOGÃO")
                                    pe.PRATELEIRA = "Z";
                                else if (pe.TIPO == "MICROONDAS")
                                    pe.PRATELEIRA = "M";
                                else if (pe.TIPO == "ASPIRADOR")
                                    pe.PRATELEIRA = "A";
                                else if (pe.TIPO == "AR CONDICIONADO")
                                    pe.PRATELEIRA = "X";
                                else if (pe.TIPO == "CLIMATIZADOR")
                                    pe.PRATELEIRA = "C";
                                else if (pe.TIPO == "COIFA")
                                    pe.PRATELEIRA = "W";
                                pe.QTDE = Convert.ToInt32(dgvPecas.Rows[op].Cells[3].Value);
                                pe.PRECO = Convert.ToString(dgvPecas.Rows[op].Cells[4].Value);
                                pe.IDCLIENTE = Convert.ToInt32(dgvPecas.Rows[op].Cells[5].Value);
                                pe.PE_SVO = Convert.ToString(dgvPecas.Rows[op].Cells[6].Value);
                                db.Entry(pe).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                            }

                        }
                        MessageBox.Show("Peças Cadastradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        dgvPecas.Rows.Clear();

                    }
                    catch(Exception err)
                    {
                        MessageBox.Show("Erro" + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }else
            {
                MessageBox.Show("Não há nenhuma peça adicionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        PesqGeral pesq = new PesqGeral();
        private void btPesqAluno_Click(object sender, EventArgs e)
        {

            pesq.Load += pesqDiag_Load;
            pesq.btPesqDoc.Click += btPDiag_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDCli, txtDescCli, pesq.retornoID, pesq.retornoDesc);
            ckbPedEstoq.Checked = false;

        }

        private void pesqDiag_Load(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                pesq.dgvPesq.DataSource = db.cliente.Select(d => new
                {
                    ID = d.ID,
                    DESCRICAO = d.NOME,
                    CPF = d.CPF,
                    CIDADE = d.CIDADE,
                    ENDEREÇO = d.ENDERECO,
                    NUMERO_CASA = d.NUMERO_CASA,
                    CELULAR = d.CELULAR

                }).ToList();
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

            return db.cliente.Where(d => d.NOME.Contains(pesquisa)).Select(d => new
            {
                ID = d.ID,
                DESCRICAO = d.NOME,
                CPF = d.CPF,
                CIDADE = d.CIDADE,
                ENDEREÇO = d.ENDERECO,
                NUMERO_CASA = d.NUMERO_CASA,
                CELULAR = d.CELULAR

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

        private void dgvPecas_MouseDown(object sender, MouseEventArgs e)
        {
            if(dgvPecas.Rows.Count > 1)
                Linha = Convert.ToInt32(dgvPecas.CurrentCell.RowIndex);
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPecas.Rows.Count > 1)
                dgvPecas.Rows.RemoveAt(Linha);
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente ca = new FormCadCliente();
            ca.StartPosition = FormStartPosition.CenterScreen;
            ca.ShowDialog();
        }
    }
}
