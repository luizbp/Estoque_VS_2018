using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.ConfigServer.Classes;
using Estoque.Models;

namespace Estoque
{
    public partial class FormLogin : Form
    {
        int IDUser;
        public FormLogin()
        {
            InitializeComponent();
            ConfigArq.verifConfig();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                try
                {
                    if (verificaCampos() == true)
                    {
                        int usu = db.login.Where(d => d.LOGIN1 == txtLogin.Text && d.SENHA == txtSenha.Text).Count();
                        if (usu > 0)
                        {
                            IDUser = db.login.Where(d => d.LOGIN1 == txtLogin.Text && d.SENHA == txtSenha.Text).FirstOrDefault().ID;
                            this.Visible = false;
                            FormPrincipal fo = new FormPrincipal(IDUser);
                            fo.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario ou senha incorretos, tente novamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSenha.Clear();
                            txtLogin.Focus();
                            txtLogin.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Erro" + er, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else e.Cancel = true;
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEntrar_Click(sender, e);
            }
        }

        private bool verificaCampos()
        {
            if (txtLogin.Text != string.Empty && txtLogin.Text != string.Empty)
                return true;
            else return false;
        }
    }
}
