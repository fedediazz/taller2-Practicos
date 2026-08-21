using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_3_Beck_Pablo
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void FormPractico3_Load(object sender, EventArgs e)
        {

        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CNaranja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RVaron_CheckedChanged(object sender, EventArgs e)
        {
            PGenero.BackgroundImage = Image.FromFile(@"C:\Users\Pablo\Desktop\Trabajos\Taller de Programación II\Trabajo_Practico_3_Beck_Pablo\Trabajo_Practico_3_Beck_Pablo\Properties\img\img_hombre.png");
        }

        private void RMujer_CheckedChanged(object sender, EventArgs e)
        {
            PGenero.BackgroundImage = Image.FromFile(@"C:\Users\Pablo\Desktop\Trabajos\Taller de Programación II\Trabajo_Practico_3_Beck_Pablo\Trabajo_Practico_3_Beck_Pablo\Properties\img\img_mujer.png");
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {

            // 2. Mensaje de advertencia con focus en "NO" (Button2)
            DialogResult askEliminar;
            askEliminar = MessageBox.Show("Está a punto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (askEliminar == DialogResult.Yes)
            {
                // --- LIMPIEZA TOTAL DE INTERFAZ ---

                // Limpiar todos los TextBox
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();

                // Limpiar el Label de estado
                LModificar.Text = "Cliente eliminado";

                // Desmarcar RadioButtons de género
                RVaron.Checked = false;
                RMujer.Checked = false;

                // Limpiar el panel de la imagen de género de forma segura
                if (PGenero.BackgroundImage != null)
                {
                    PGenero.BackgroundImage.Dispose(); // Libera la memoria del archivo de imagen
                    PGenero.BackgroundImage = null;    // Quita el fondo del panel
                }

                // Desmarcar CheckBoxes de tarjetas
                CVisa.Checked = false;
                CMastercard.Checked = false;
                CNaranja.Checked = false;

                // Forzar a la interfaz gráfica a dibujarse de nuevo inmediatamente
                this.Refresh();

                // 3. Mensaje final de confirmación de eliminación
                MessageBox.Show("El Cliente: " + LModificar.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Devolver el cursor al inicio
                TDni.Focus();
            }
        }


        private void BGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar campos vacíos
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 2. Validar que el DNI sea numérico
            else if (!int.TryParse(TDni.Text, out _))
            {
                MessageBox.Show("EL DNI Debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 3. Validar que al menos haya seleccionado un género
            else if (!RVaron.Checked && !RMujer.Checked)
            {
                MessageBox.Show("Debe seleccionar un género (Varón o Mujer)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Preguntar confirmación al usuario
                DialogResult ask;
                ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    // --- CAPTURA DE DATOS EXTRAS (Por si necesitas usarlos o guardarlos en variables) ---
                    string genero = RVaron.Checked ? "Varón" : "Mujer";

                    string tarjetas = "";
                    if (CVisa.Checked) tarjetas += "Visa ";
                    if (CMastercard.Checked) tarjetas += "Mastercard ";
                    if (CNaranja.Checked) tarjetas += "Naranja";
                    if (string.IsNullOrEmpty(tarjetas)) tarjetas = "Ninguna";

                    // Mensaje de éxito original
                    MessageBox.Show("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Modificar el label indicador
                    LModificar.Text = TNombre.Text + " " + TApellido.Text;

                    // --- LIMPIEZA AUTOMÁTICA DEL FORMULARIO ---
                    // Borra los textos
                    TDni.Clear();
                    TApellido.Clear();
                    TNombre.Clear();
                    
                    // Desmarca los RadioButtons de género
                    RVaron.Checked = false;
                    RMujer.Checked = false;

                    // Quita la imagen de fondo del panel de género (vuelve a estar vacío)
                    if (PGenero.BackgroundImage != null)
                    {
                        PGenero.BackgroundImage.Dispose(); // Libera la memoria de la imagen previa
                        PGenero.BackgroundImage = null;
                    }

                    // Desmarca las tarjetas de crédito
                    CVisa.Checked = false;
                    CMastercard.Checked = false;
                    CNaranja.Checked = false;

                    // Devuelve el cursor (foco) a la primera caja de texto
                    TDni.Focus();
                }
            }
        }


        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CVisa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CMastercard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}