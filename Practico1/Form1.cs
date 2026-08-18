using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Concatena el Apellido y el Nombre con un espacio en medio
            txtResultado.Text = txtApellido.Text + " " + txtNombre.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            // Finaliza la ejecución de la aplicación
            Application.Exit();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            // Habilita el control
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;

            // Permite la edición
            txtApellido.ReadOnly = false;
            txtNombre.ReadOnly = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Habilita el control
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;

            // Permite la edición
            txtApellido.ReadOnly = false;
            txtNombre.ReadOnly = false;
        }
    }
}


