using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite solo digitos numericos
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios en blanco y teclas de control (como Retroceso / Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea números o caracteres especiales
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios en blanco y teclas de control (como Retroceso / Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea números o caracteres especiales
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            // 1. Verificación de campos incompletos
            if (TDni.Text.Trim() == "" || TApellido.Text.Trim() == "" || TNombre.Text.Trim() == "")
            {
                DialogResult ask;
                ask = MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // 2. Pregunta de confirmación al usuario
                DialogResult ask;

                ask = MessageBox.Show(
                    "Seguro que desea insertar un nuevo Cliente?",
                    "Confirmar Insercion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                // 3. Si confirma haciendo clic en "SÍ"
                if (ask == DialogResult.Yes)
                {
                    // Concatenación de los campos para la acción solicitada
                    LModificar.Text = $"{TNombre.Text} {TApellido.Text}";
                    //LModificar.Text = "Modificado";

                    // 4. MsgBox de Información con el nombre ingresado
                    MessageBox.Show(
                        $"El Cliente: {TNombre.Text} {TApellido.Text} se insertó correctamente",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }

            }

        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            // Guardamos el nombre completo en una variable antes de limpiar los campos
            string cliente = $"{TNombre.Text} {TApellido.Text}";

            // Variable para capturar la respuesta
            DialogResult ask;

            // MsgBox de Exclamación con el focus en "NO" (Button2)
            ask = MessageBox.Show(
                $"Está apunto de eliminar el Cliente: {cliente}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2
            );

            // Evaluación: si presiona "SÍ" ejecuta la eliminación
            if (ask == DialogResult.Yes)
            {
                // 1. Muestra el mensaje de confirmación
                MessageBox.Show(
                    $"El Cliente: {cliente} se eliminó correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // 2. Limpia todos los TextBox
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                //txtResultado.Clear(); // Reemplazar por el Name real de tu TextBox multilínea

                // 3. Limpia el Label Lmodificar
                LModificar.Text = "";
            }
            // Si presiona "NO", no ejecuta nada y el código finaliza sin hacer cambios
        }
    }

}