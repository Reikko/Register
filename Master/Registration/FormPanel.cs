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
    public partial class FormPanel : Form
    {
        public FormCliente cliente;
        public FormPanel()
        {
            InitializeComponent();
            cliente = new FormCliente();
        }

        private void tsRegCliente_Click(object sender, EventArgs e)
        {
            cliente.ShowDialog();
        }

        private void FormPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
