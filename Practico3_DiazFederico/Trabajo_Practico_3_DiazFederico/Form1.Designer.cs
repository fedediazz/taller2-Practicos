namespace Trabajo_Practico_3_Beck_Pablo
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LNuevoCliente = new System.Windows.Forms.Label();
            this.formulario = new System.Windows.Forms.Panel();
            this.CMastercard = new System.Windows.Forms.CheckBox();
            this.CVisa = new System.Windows.Forms.CheckBox();
            this.CNaranja = new System.Windows.Forms.CheckBox();
            this.LTarjetas = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LNya = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PGenero = new System.Windows.Forms.Panel();
            this.RMujer = new System.Windows.Forms.RadioButton();
            this.RVaron = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // LNuevoCliente
            // 
            this.LNuevoCliente.AutoSize = true;
            this.LNuevoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.LNuevoCliente.Location = new System.Drawing.Point(351, 18);
            this.LNuevoCliente.Name = "LNuevoCliente";
            this.LNuevoCliente.Size = new System.Drawing.Size(219, 34);
            this.LNuevoCliente.TabIndex = 0;
            this.LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // formulario
            // 
            this.formulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.formulario.Controls.Add(this.CMastercard);
            this.formulario.Controls.Add(this.CVisa);
            this.formulario.Controls.Add(this.CNaranja);
            this.formulario.Controls.Add(this.LTarjetas);
            this.formulario.Controls.Add(this.TNombre);
            this.formulario.Controls.Add(this.LDni);
            this.formulario.Controls.Add(this.LModificar);
            this.formulario.Controls.Add(this.LNombre);
            this.formulario.Controls.Add(this.TApellido);
            this.formulario.Controls.Add(this.LNya);
            this.formulario.Controls.Add(this.LApellido);
            this.formulario.Controls.Add(this.TDni);
            this.formulario.Location = new System.Drawing.Point(37, 80);
            this.formulario.Name = "formulario";
            this.formulario.Size = new System.Drawing.Size(415, 446);
            this.formulario.TabIndex = 1;
            // 
            // CMastercard
            // 
            this.CMastercard.AutoSize = true;
            this.CMastercard.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.CMastercard.Location = new System.Drawing.Point(201, 398);
            this.CMastercard.Name = "CMastercard";
            this.CMastercard.Size = new System.Drawing.Size(126, 31);
            this.CMastercard.TabIndex = 24;
            this.CMastercard.Text = "Mastercard";
            this.CMastercard.UseVisualStyleBackColor = true;
            this.CMastercard.CheckedChanged += new System.EventHandler(this.CMastercard_CheckedChanged);
            // 
            // CVisa
            // 
            this.CVisa.AutoSize = true;
            this.CVisa.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.CVisa.Location = new System.Drawing.Point(201, 345);
            this.CVisa.Name = "CVisa";
            this.CVisa.Size = new System.Drawing.Size(70, 31);
            this.CVisa.TabIndex = 23;
            this.CVisa.Text = "Visa";
            this.CVisa.UseVisualStyleBackColor = true;
            this.CVisa.CheckedChanged += new System.EventHandler(this.CVisa_CheckedChanged);
            // 
            // CNaranja
            // 
            this.CNaranja.AutoSize = true;
            this.CNaranja.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.CNaranja.Location = new System.Drawing.Point(201, 295);
            this.CNaranja.Name = "CNaranja";
            this.CNaranja.Size = new System.Drawing.Size(98, 31);
            this.CNaranja.TabIndex = 22;
            this.CNaranja.Text = "Naranja";
            this.CNaranja.UseVisualStyleBackColor = true;
            this.CNaranja.CheckedChanged += new System.EventHandler(this.CNaranja_CheckedChanged);
            // 
            // LTarjetas
            // 
            this.LTarjetas.AutoSize = true;
            this.LTarjetas.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.LTarjetas.Location = new System.Drawing.Point(19, 295);
            this.LTarjetas.Name = "LTarjetas";
            this.LTarjetas.Size = new System.Drawing.Size(176, 27);
            this.LTarjetas.TabIndex = 21;
            this.LTarjetas.Text = "Tarjetas de creditos:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(103, 226);
            this.TNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TNombre.Multiline = true;
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(266, 38);
            this.TNombre.TabIndex = 20;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(19, 94);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(44, 27);
            this.LDni.TabIndex = 15;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.LDni_Click);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.LModificar.Location = new System.Drawing.Point(203, 36);
            this.LModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(87, 27);
            this.LModificar.TabIndex = 14;
            this.LModificar.Text = "Modificar";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(19, 224);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(78, 27);
            this.LNombre.TabIndex = 17;
            this.LNombre.Text = "Nombre";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(103, 159);
            this.TApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TApellido.Multiline = true;
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(266, 38);
            this.TApellido.TabIndex = 19;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNya.Location = new System.Drawing.Point(17, 36);
            this.LNya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(162, 27);
            this.LNya.TabIndex = 12;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(17, 159);
            this.LApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(77, 27);
            this.LApellido.TabIndex = 16;
            this.LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(103, 96);
            this.TDni.Margin = new System.Windows.Forms.Padding(4);
            this.TDni.Multiline = true;
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(266, 38);
            this.TDni.TabIndex = 18;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 13;
            // 
            // PGenero
            // 
            this.PGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PGenero.Location = new System.Drawing.Point(539, 80);
            this.PGenero.Name = "PGenero";
            this.PGenero.Size = new System.Drawing.Size(215, 218);
            this.PGenero.TabIndex = 19;
            // 
            // RMujer
            // 
            this.RMujer.AutoSize = true;
            this.RMujer.Location = new System.Drawing.Point(693, 324);
            this.RMujer.Name = "RMujer";
            this.RMujer.Size = new System.Drawing.Size(61, 20);
            this.RMujer.TabIndex = 15;
            this.RMujer.TabStop = true;
            this.RMujer.Text = "Mujer";
            this.RMujer.UseVisualStyleBackColor = true;
            this.RMujer.CheckedChanged += new System.EventHandler(this.RMujer_CheckedChanged);
            // 
            // RVaron
            // 
            this.RVaron.AutoSize = true;
            this.RVaron.Location = new System.Drawing.Point(539, 324);
            this.RVaron.Name = "RVaron";
            this.RVaron.Size = new System.Drawing.Size(64, 20);
            this.RVaron.TabIndex = 14;
            this.RVaron.TabStop = true;
            this.RVaron.Text = "Varon";
            this.RVaron.UseVisualStyleBackColor = true;
            this.RVaron.CheckedChanged += new System.EventHandler(this.RVaron_CheckedChanged);
            // 
            // BSalir
            // 
            this.BSalir.BackgroundImage = global::Trabajo_Practico_3_Beck_Pablo.Properties.Resources.btnSalir;
            this.BSalir.Location = new System.Drawing.Point(539, 575);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(91, 47);
            this.BSalir.TabIndex = 18;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackgroundImage = global::Trabajo_Practico_3_Beck_Pablo.Properties.Resources.btnEliminar;
            this.BEliminar.Location = new System.Drawing.Point(331, 578);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(92, 44);
            this.BEliminar.TabIndex = 17;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackgroundImage = global::Trabajo_Practico_3_Beck_Pablo.Properties.Resources.btnGuardar;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BGuardar.Location = new System.Drawing.Point(130, 574);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(98, 48);
            this.BGuardar.TabIndex = 16;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // MDIParent1
            // 
            this.ClientSize = new System.Drawing.Size(808, 646);
            this.Controls.Add(this.RVaron);
            this.Controls.Add(this.RMujer);
            this.Controls.Add(this.PGenero);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formulario);
            this.Controls.Add(this.LNuevoCliente);
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequelo Formulario";
            this.Load += new System.EventHandler(this.FormPractico3_Load);
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNuevoCliente;
        private System.Windows.Forms.Panel formulario;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LTarjetas;
        private System.Windows.Forms.CheckBox CMastercard;
        private System.Windows.Forms.CheckBox CVisa;
        private System.Windows.Forms.CheckBox CNaranja;
        private System.Windows.Forms.RadioButton RVaron;
        private System.Windows.Forms.RadioButton RMujer;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Panel PGenero;
    }
}