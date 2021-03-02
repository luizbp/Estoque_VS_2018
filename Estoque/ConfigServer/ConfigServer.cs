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

namespace Estoque.ConfigServer
{
    public partial class ConfigServer : Form
    {
        int close;
        public ConfigServer()
        {
            InitializeComponent();
        }
        private void btConfig_Click(object sender, EventArgs e)
        {
            if (verificarCampos() == false)
            {
                ConfigArq.Criar(txtIP.Text, txtPorta.Text, txtUser.Text, txtPwd.Text, txtNomeDb.Text);
                close = 1;
                this.Close();
            }
            else MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente cancelar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void ConfigServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btConfig_Click(null, null);
            else if (e.KeyCode == Keys.F9)
                btSair_Click(null, null);
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.A)
            {
                if (txtIP.Focused)
                {
                    txtIP.SelectAll();
                }
                else if (txtNomeDb.Focused)
                {
                    txtNomeDb.SelectAll();
                }
                else if (txtPorta.Focused)
                {
                    txtPorta.SelectAll();
                }
                else if (txtPwd.Focused)
                {
                    txtPwd.SelectAll();
                }
                else if (txtUser.Focused)
                {
                    txtUser.SelectAll();
                }

            }
        }

        private bool verificarCampos()
        {
            if (txtIP.Text == String.Empty || txtNomeDb.Text == String.Empty || txtPorta.Text == String.Empty || txtPwd.Text == String.Empty || txtUser.Text == String.Empty)
            {
                return true;
            }
            else return false;
        }

        private void ConfigServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == 0)
                Environment.Exit(0);
        }

    }
}
