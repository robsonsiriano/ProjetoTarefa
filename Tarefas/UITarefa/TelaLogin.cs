using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITarefa
{
    public partial class TelaLogin : Form
    {
        public bool Logou;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuario(nomeTextBox.Text);
            if (usuarioBindingSource.Count != 0)
            {
                string nome = ((DataRowView)usuarioBindingSource.Current).Row["Nome"].ToString();
                string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();
                if (nome == nomeTextBox.Text && senha == senhaTextBox.Text)

                {
                    Logou = true;
                    frmTarefa frm = new frmTarefa();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Incorreta");
                    nomeTextBox.Text = "";
                    senhaTextBox.Focus();
                }
            }

            else
            {
                MessageBox.Show("Usuario ou Senha Incorreta");
                nomeTextBox.Text = "";
                senhaTextBox.Focus();
            }
            }
        }
    }

