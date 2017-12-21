using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Registration
{
    public partial class FormCliente : Form
    {
        public List<Cliente> listCliente;
        public FormCliente()
        {
            InitializeComponent();
            listCliente = new List<Cliente>();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            cl.nombre = txtNombre.Text;
            cl.paterno = txtPaterno.Text;
            cl.materno = txtMaterno.Text;
            listCliente.Add(cl);
            //Limpiar Campos
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
