namespace AeroDrago
{
    partial class FrmAltaVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFechaPartidaNacional = new System.Windows.Forms.DateTimePicker();
            this.gBoxDatosVuelo = new System.Windows.Forms.GroupBox();
            this.radDestinoNacional = new System.Windows.Forms.RadioButton();
            this.radDestinoInternacional = new System.Windows.Forms.RadioButton();
            this.gBoxVueloInternacional = new System.Windows.Forms.GroupBox();
            this.cboIdAeronaveInt = new System.Windows.Forms.ComboBox();
            this.cboDestinoInternacional = new System.Windows.Forms.ComboBox();
            this.cboOrigenNacionalInt = new System.Windows.Forms.ComboBox();
            this.labIdAeronaveInt = new System.Windows.Forms.Label();
            this.labDestinoInternacional = new System.Windows.Forms.Label();
            this.labOrigenNacionalInt = new System.Windows.Forms.Label();
            this.labFechaPartidaInternacional = new System.Windows.Forms.Label();
            this.dtpFechaPartidaInternacional = new System.Windows.Forms.DateTimePicker();
            this.gBoxVueloNacional = new System.Windows.Forms.GroupBox();
            this.cboIdAeronaveNac = new System.Windows.Forms.ComboBox();
            this.cboDestinoNacional = new System.Windows.Forms.ComboBox();
            this.cboOrigenNacional = new System.Windows.Forms.ComboBox();
            this.labIdAeronaveNac = new System.Windows.Forms.Label();
            this.labDestinoNacional = new System.Windows.Forms.Label();
            this.labOrigenNacional = new System.Windows.Forms.Label();
            this.labFechaPartida = new System.Windows.Forms.Label();
            this.btnConfirmarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.gBoxDatosVuelo.SuspendLayout();
            this.gBoxVueloInternacional.SuspendLayout();
            this.gBoxVueloNacional.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaPartidaNacional
            // 
            this.dtpFechaPartidaNacional.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPartidaNacional.Location = new System.Drawing.Point(142, 18);
            this.dtpFechaPartidaNacional.MinDate = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            this.dtpFechaPartidaNacional.Name = "dtpFechaPartidaNacional";
            this.dtpFechaPartidaNacional.Size = new System.Drawing.Size(108, 22);
            this.dtpFechaPartidaNacional.TabIndex = 11;
            // 
            // gBoxDatosVuelo
            // 
            this.gBoxDatosVuelo.Controls.Add(this.radDestinoNacional);
            this.gBoxDatosVuelo.Controls.Add(this.radDestinoInternacional);
            this.gBoxDatosVuelo.Controls.Add(this.gBoxVueloInternacional);
            this.gBoxDatosVuelo.Controls.Add(this.gBoxVueloNacional);
            this.gBoxDatosVuelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxDatosVuelo.Location = new System.Drawing.Point(516, 15);
            this.gBoxDatosVuelo.Name = "gBoxDatosVuelo";
            this.gBoxDatosVuelo.Size = new System.Drawing.Size(273, 355);
            this.gBoxDatosVuelo.TabIndex = 12;
            this.gBoxDatosVuelo.TabStop = false;
            this.gBoxDatosVuelo.Text = "Datos del Vuelo";
            // 
            // radDestinoNacional
            // 
            this.radDestinoNacional.AutoSize = true;
            this.radDestinoNacional.Checked = true;
            this.radDestinoNacional.Location = new System.Drawing.Point(12, 30);
            this.radDestinoNacional.Name = "radDestinoNacional";
            this.radDestinoNacional.Size = new System.Drawing.Size(81, 20);
            this.radDestinoNacional.TabIndex = 20;
            this.radDestinoNacional.TabStop = true;
            this.radDestinoNacional.Text = "Nacional";
            this.radDestinoNacional.UseVisualStyleBackColor = true;
            this.radDestinoNacional.CheckedChanged += new System.EventHandler(this.radDestinoNacional_CheckedChanged);
            // 
            // radDestinoInternacional
            // 
            this.radDestinoInternacional.AutoSize = true;
            this.radDestinoInternacional.Location = new System.Drawing.Point(113, 30);
            this.radDestinoInternacional.Name = "radDestinoInternacional";
            this.radDestinoInternacional.Size = new System.Drawing.Size(109, 20);
            this.radDestinoInternacional.TabIndex = 19;
            this.radDestinoInternacional.Text = "Internacional";
            this.radDestinoInternacional.UseVisualStyleBackColor = true;
            this.radDestinoInternacional.CheckedChanged += new System.EventHandler(this.radDestinoInternacional_CheckedChanged);
            // 
            // gBoxVueloInternacional
            // 
            this.gBoxVueloInternacional.Controls.Add(this.cboIdAeronaveInt);
            this.gBoxVueloInternacional.Controls.Add(this.cboDestinoInternacional);
            this.gBoxVueloInternacional.Controls.Add(this.cboOrigenNacionalInt);
            this.gBoxVueloInternacional.Controls.Add(this.labIdAeronaveInt);
            this.gBoxVueloInternacional.Controls.Add(this.labDestinoInternacional);
            this.gBoxVueloInternacional.Controls.Add(this.labOrigenNacionalInt);
            this.gBoxVueloInternacional.Controls.Add(this.labFechaPartidaInternacional);
            this.gBoxVueloInternacional.Controls.Add(this.dtpFechaPartidaInternacional);
            this.gBoxVueloInternacional.Location = new System.Drawing.Point(6, 207);
            this.gBoxVueloInternacional.Name = "gBoxVueloInternacional";
            this.gBoxVueloInternacional.Size = new System.Drawing.Size(256, 135);
            this.gBoxVueloInternacional.TabIndex = 14;
            this.gBoxVueloInternacional.TabStop = false;
            this.gBoxVueloInternacional.Text = "Vuelo Internacional";
            this.gBoxVueloInternacional.Visible = false;
            // 
            // cboIdAeronaveInt
            // 
            this.cboIdAeronaveInt.FormattingEnabled = true;
            this.cboIdAeronaveInt.Location = new System.Drawing.Point(107, 102);
            this.cboIdAeronaveInt.Name = "cboIdAeronaveInt";
            this.cboIdAeronaveInt.Size = new System.Drawing.Size(143, 24);
            this.cboIdAeronaveInt.TabIndex = 17;
            this.cboIdAeronaveInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboIdAeronaveInt_KeyPress);
            // 
            // cboDestinoInternacional
            // 
            this.cboDestinoInternacional.FormattingEnabled = true;
            this.cboDestinoInternacional.Location = new System.Drawing.Point(107, 72);
            this.cboDestinoInternacional.Name = "cboDestinoInternacional";
            this.cboDestinoInternacional.Size = new System.Drawing.Size(143, 24);
            this.cboDestinoInternacional.TabIndex = 16;
            this.cboDestinoInternacional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDestinoInternacional_KeyPress);
            // 
            // cboOrigenNacionalInt
            // 
            this.cboOrigenNacionalInt.FormattingEnabled = true;
            this.cboOrigenNacionalInt.Items.AddRange(new object[] {
            "BuenosAires"});
            this.cboOrigenNacionalInt.Location = new System.Drawing.Point(107, 44);
            this.cboOrigenNacionalInt.Name = "cboOrigenNacionalInt";
            this.cboOrigenNacionalInt.Size = new System.Drawing.Size(143, 24);
            this.cboOrigenNacionalInt.TabIndex = 15;
            this.cboOrigenNacionalInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOrigenNacionalInt_KeyPress);
            // 
            // labIdAeronaveInt
            // 
            this.labIdAeronaveInt.AutoSize = true;
            this.labIdAeronaveInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labIdAeronaveInt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labIdAeronaveInt.Location = new System.Drawing.Point(6, 106);
            this.labIdAeronaveInt.Name = "labIdAeronaveInt";
            this.labIdAeronaveInt.Size = new System.Drawing.Size(98, 20);
            this.labIdAeronaveInt.TabIndex = 14;
            this.labIdAeronaveInt.Text = "Id Aeronave:";
            // 
            // labDestinoInternacional
            // 
            this.labDestinoInternacional.AutoSize = true;
            this.labDestinoInternacional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labDestinoInternacional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDestinoInternacional.Location = new System.Drawing.Point(6, 77);
            this.labDestinoInternacional.Name = "labDestinoInternacional";
            this.labDestinoInternacional.Size = new System.Drawing.Size(69, 20);
            this.labDestinoInternacional.TabIndex = 13;
            this.labDestinoInternacional.Text = "Destino:";
            // 
            // labOrigenNacionalInt
            // 
            this.labOrigenNacionalInt.AutoSize = true;
            this.labOrigenNacionalInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labOrigenNacionalInt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labOrigenNacionalInt.Location = new System.Drawing.Point(6, 48);
            this.labOrigenNacionalInt.Name = "labOrigenNacionalInt";
            this.labOrigenNacionalInt.Size = new System.Drawing.Size(63, 20);
            this.labOrigenNacionalInt.TabIndex = 12;
            this.labOrigenNacionalInt.Text = "Origen:";
            // 
            // labFechaPartidaInternacional
            // 
            this.labFechaPartidaInternacional.AutoSize = true;
            this.labFechaPartidaInternacional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labFechaPartidaInternacional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFechaPartidaInternacional.Location = new System.Drawing.Point(6, 18);
            this.labFechaPartidaInternacional.Name = "labFechaPartidaInternacional";
            this.labFechaPartidaInternacional.Size = new System.Drawing.Size(132, 20);
            this.labFechaPartidaInternacional.TabIndex = 0;
            this.labFechaPartidaInternacional.Text = "Fecha de partida:";
            // 
            // dtpFechaPartidaInternacional
            // 
            this.dtpFechaPartidaInternacional.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPartidaInternacional.Location = new System.Drawing.Point(142, 18);
            this.dtpFechaPartidaInternacional.MinDate = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            this.dtpFechaPartidaInternacional.Name = "dtpFechaPartidaInternacional";
            this.dtpFechaPartidaInternacional.Size = new System.Drawing.Size(108, 22);
            this.dtpFechaPartidaInternacional.TabIndex = 11;
            // 
            // gBoxVueloNacional
            // 
            this.gBoxVueloNacional.Controls.Add(this.cboIdAeronaveNac);
            this.gBoxVueloNacional.Controls.Add(this.cboDestinoNacional);
            this.gBoxVueloNacional.Controls.Add(this.cboOrigenNacional);
            this.gBoxVueloNacional.Controls.Add(this.labIdAeronaveNac);
            this.gBoxVueloNacional.Controls.Add(this.labDestinoNacional);
            this.gBoxVueloNacional.Controls.Add(this.labOrigenNacional);
            this.gBoxVueloNacional.Controls.Add(this.labFechaPartida);
            this.gBoxVueloNacional.Controls.Add(this.dtpFechaPartidaNacional);
            this.gBoxVueloNacional.Location = new System.Drawing.Point(6, 66);
            this.gBoxVueloNacional.Name = "gBoxVueloNacional";
            this.gBoxVueloNacional.Size = new System.Drawing.Size(256, 135);
            this.gBoxVueloNacional.TabIndex = 13;
            this.gBoxVueloNacional.TabStop = false;
            this.gBoxVueloNacional.Text = "Vuelo Nacional";
            this.gBoxVueloNacional.Visible = false;
            // 
            // cboIdAeronaveNac
            // 
            this.cboIdAeronaveNac.FormattingEnabled = true;
            this.cboIdAeronaveNac.Location = new System.Drawing.Point(107, 102);
            this.cboIdAeronaveNac.Name = "cboIdAeronaveNac";
            this.cboIdAeronaveNac.Size = new System.Drawing.Size(143, 24);
            this.cboIdAeronaveNac.TabIndex = 17;
            this.cboIdAeronaveNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboIdAeronaveNac_KeyPress);
            // 
            // cboDestinoNacional
            // 
            this.cboDestinoNacional.FormattingEnabled = true;
            this.cboDestinoNacional.Location = new System.Drawing.Point(107, 72);
            this.cboDestinoNacional.Name = "cboDestinoNacional";
            this.cboDestinoNacional.Size = new System.Drawing.Size(143, 24);
            this.cboDestinoNacional.TabIndex = 16;
            this.cboDestinoNacional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDestinoNacional_KeyPress);
            // 
            // cboOrigenNacional
            // 
            this.cboOrigenNacional.FormattingEnabled = true;
            this.cboOrigenNacional.Location = new System.Drawing.Point(107, 44);
            this.cboOrigenNacional.Name = "cboOrigenNacional";
            this.cboOrigenNacional.Size = new System.Drawing.Size(143, 24);
            this.cboOrigenNacional.TabIndex = 15;
            this.cboOrigenNacional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOrigenNacional_KeyPress);
            // 
            // labIdAeronaveNac
            // 
            this.labIdAeronaveNac.AutoSize = true;
            this.labIdAeronaveNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labIdAeronaveNac.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labIdAeronaveNac.Location = new System.Drawing.Point(6, 106);
            this.labIdAeronaveNac.Name = "labIdAeronaveNac";
            this.labIdAeronaveNac.Size = new System.Drawing.Size(98, 20);
            this.labIdAeronaveNac.TabIndex = 14;
            this.labIdAeronaveNac.Text = "Id Aeronave:";
            // 
            // labDestinoNacional
            // 
            this.labDestinoNacional.AutoSize = true;
            this.labDestinoNacional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labDestinoNacional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDestinoNacional.Location = new System.Drawing.Point(6, 77);
            this.labDestinoNacional.Name = "labDestinoNacional";
            this.labDestinoNacional.Size = new System.Drawing.Size(69, 20);
            this.labDestinoNacional.TabIndex = 13;
            this.labDestinoNacional.Text = "Destino:";
            // 
            // labOrigenNacional
            // 
            this.labOrigenNacional.AutoSize = true;
            this.labOrigenNacional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labOrigenNacional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labOrigenNacional.Location = new System.Drawing.Point(6, 48);
            this.labOrigenNacional.Name = "labOrigenNacional";
            this.labOrigenNacional.Size = new System.Drawing.Size(63, 20);
            this.labOrigenNacional.TabIndex = 12;
            this.labOrigenNacional.Text = "Origen:";
            // 
            // labFechaPartida
            // 
            this.labFechaPartida.AutoSize = true;
            this.labFechaPartida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labFechaPartida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFechaPartida.Location = new System.Drawing.Point(6, 18);
            this.labFechaPartida.Name = "labFechaPartida";
            this.labFechaPartida.Size = new System.Drawing.Size(132, 20);
            this.labFechaPartida.TabIndex = 0;
            this.labFechaPartida.Text = "Fecha de partida:";
            // 
            // btnConfirmarAlta
            // 
            this.btnConfirmarAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmarAlta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarAlta.Location = new System.Drawing.Point(516, 394);
            this.btnConfirmarAlta.Name = "btnConfirmarAlta";
            this.btnConfirmarAlta.Size = new System.Drawing.Size(125, 34);
            this.btnConfirmarAlta.TabIndex = 17;
            this.btnConfirmarAlta.Text = "Confirmar Alta";
            this.btnConfirmarAlta.UseVisualStyleBackColor = false;
            this.btnConfirmarAlta.Click += new System.EventHandler(this.btnConfirmarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarAlta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarAlta.Location = new System.Drawing.Point(664, 394);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(125, 34);
            this.btnCancelarAlta.TabIndex = 18;
            this.btnCancelarAlta.Text = "Cancelar Alta";
            this.btnCancelarAlta.UseVisualStyleBackColor = false;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // FrmAltaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::AeroDrago.Properties.Resources.aero_drago;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(811, 494);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnConfirmarAlta);
            this.Controls.Add(this.gBoxDatosVuelo);
            this.DoubleBuffered = true;
            this.Name = "FrmAltaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aero Drago > Alta de Vuelo";
            this.Load += new System.EventHandler(this.FrmAltaVuelo_Load);
            this.gBoxDatosVuelo.ResumeLayout(false);
            this.gBoxDatosVuelo.PerformLayout();
            this.gBoxVueloInternacional.ResumeLayout(false);
            this.gBoxVueloInternacional.PerformLayout();
            this.gBoxVueloNacional.ResumeLayout(false);
            this.gBoxVueloNacional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker dtpFechaPartidaNacional;
        private GroupBox gBoxDatosVuelo;
        private Label labFechaPartida;
        private GroupBox gBoxVueloNacional;
        private Label labDestinoNacional;
        private Label labOrigenNacional;
        private Label labIdAeronaveNac;
        private ComboBox cboIdAeronaveNac;
        private ComboBox cboDestinoNacional;
        private ComboBox cboOrigenNacional;
        private GroupBox gBoxVueloInternacional;
        private ComboBox cboIdAeronaveInt;
        private ComboBox cboDestinoInternacional;
        private ComboBox cboOrigenNacionalInt;
        private Label labIdAeronaveInt;
        private Label labDestinoInternacional;
        private Label labOrigenNacionalInt;
        private Label labFechaPartidaInternacional;
        private DateTimePicker dtpFechaPartidaInternacional;
        private Button btnConfirmarAlta;
        private Button btnCancelarAlta;
        private RadioButton radDestinoNacional;
        private RadioButton radDestinoInternacional;
    }
}