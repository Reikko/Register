using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Solo acceder si hay credenciales/usuarios registrados
            this.Visible = false;
            FormPanel panel = new FormPanel();
            panel.ShowDialog();
            this.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
