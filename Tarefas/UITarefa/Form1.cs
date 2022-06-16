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
    public partial class frmTarefa : Form
    {
        public frmTarefa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            using (TelaLogin frm = new TelaLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                   Application.Exit();
            }

        }
    }
}
