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
    public partial class FormPrincipal : Form
    {
        int IDUser;
        public FormPrincipal(int idUsu)
        {
            InitializeComponent();
            IDUser = idUsu;
        }

        private void MenuConsulta_Click(object sender, EventArgs e)
        {
            FormConsulta fo = new FormConsulta();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void MenuEntrada_Click(object sender, EventArgs e)
        {
            FormEntrada fo = new FormEntrada();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else e.Cancel = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                login lo = db.login.Find(IDUser);
                txtUsu.Text = lo.NOME;
            }
        }

        private void MenuSaida_Click(object sender, EventArgs e)
        {
            FormSaida fo = new FormSaida(0,"");
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void MenuRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio fo = new FormRelatorio();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void MenuOrcamento_Click(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                login lo = db.login.Find(IDUser);
                if (lo.PERMISSAO == "U")
                {
                    FormOrcamentos fo = new FormOrcamentos();
                    fo.WindowState = FormWindowState.Normal;
                    fo.StartPosition = FormStartPosition.CenterParent;
                    fo.ShowDialog();
                }
                else if (lo.PERMISSAO == "A")
                {
                    FormOrcamentoAdm fo = new FormOrcamentoAdm();
                    fo.WindowState = FormWindowState.Normal;
                    fo.StartPosition = FormStartPosition.CenterParent;
                    fo.ShowDialog();
                }
            }
        }

        private void MenuInfo_Click(object sender, EventArgs e)
        {
            FormInfo fo = new FormInfo();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void btLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
