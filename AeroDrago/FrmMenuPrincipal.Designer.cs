namespace AeroDrago
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.labNombreOperador = new System.Windows.Forms.Label();
            this.dtgVuelosNacionales = new System.Windows.Forms.DataGridView();
            this.dtpFechaIda = new System.Windows.Forms.DateTimePicker();
            this.gboxVuelosNacionales = new System.Windows.Forms.GroupBox();
            this.gBoxVuelosInternacionales = new System.Windows.Forms.GroupBox();
            this.dtgVuelosInternacionales = new System.Windows.Forms.DataGridView();
            this.btnMostrarVuelos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAltaVuelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosNacionales)).BeginInit();
            this.gboxVuelosNacionales.SuspendLayout();
            this.gBoxVuelosInternacionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosInternacionales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(810, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 492);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(125, 34);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // labNombreOperador
            // 
            this.labNombreOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labNombreOperador.AutoSize = true;
            this.labNombreOperador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labNombreOperador.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.labNombreOperador.Location = new System.Drawing.Point(337, 2);
            this.labNombreOperador.Name = "labNombreOperador";
            this.labNombreOperador.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labNombreOperador.Size = new System.Drawing.Size(120, 17);
            this.labNombreOperador.TabIndex = 7;
            this.labNombreOperador.Text = "Nombre Operador";
            this.labNombreOperador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgVuelosNacionales
            // 
            this.dtgVuelosNacionales.AllowUserToAddRows = false;
            this.dtgVuelosNacionales.AllowUserToDeleteRows = false;
            this.dtgVuelosNacionales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVuelosNacionales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVuelosNacionales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgVuelosNacionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelosNacionales.Location = new System.Drawing.Point(6, 18);
            this.dtgVuelosNacionales.Name = "dtgVuelosNacionales";
            this.dtgVuelosNacionales.ReadOnly = true;
            this.dtgVuelosNacionales.RowHeadersVisible = false;
            this.dtgVuelosNacionales.RowTemplate.Height = 25;
            this.dtgVuelosNacionales.Size = new System.Drawing.Size(900, 190);
            this.dtgVuelosNacionales.TabIndex = 8;
            this.dtgVuelosNacionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVuelosNacionales_CellContentClick);
            // 
            // dtpFechaIda
            // 
            this.dtpFechaIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIda.Location = new System.Drawing.Point(63, 463);
            this.dtpFechaIda.MinDate = new System.DateTime(2022, 9, 30, 0, 0, 0, 0);
            this.dtpFechaIda.Name = "dtpFechaIda";
            this.dtpFechaIda.Size = new System.Drawing.Size(90, 23);
            this.dtpFechaIda.TabIndex = 10;
            // 
            // gboxVuelosNacionales
            // 
            this.gboxVuelosNacionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gboxVuelosNacionales.Controls.Add(this.dtgVuelosNacionales);
            this.gboxVuelosNacionales.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxVuelosNacionales.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gboxVuelosNacionales.Location = new System.Drawing.Point(12, 22);
            this.gboxVuelosNacionales.Name = "gboxVuelosNacionales";
            this.gboxVuelosNacionales.Size = new System.Drawing.Size(912, 214);
            this.gboxVuelosNacionales.TabIndex = 12;
            this.gboxVuelosNacionales.TabStop = false;
            this.gboxVuelosNacionales.Text = "Vuelos Nacionales";
            // 
            // gBoxVuelosInternacionales
            // 
            this.gBoxVuelosInternacionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gBoxVuelosInternacionales.Controls.Add(this.dtgVuelosInternacionales);
            this.gBoxVuelosInternacionales.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxVuelosInternacionales.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBoxVuelosInternacionales.Location = new System.Drawing.Point(12, 236);
            this.gBoxVuelosInternacionales.Name = "gBoxVuelosInternacionales";
            this.gBoxVuelosInternacionales.Size = new System.Drawing.Size(912, 214);
            this.gBoxVuelosInternacionales.TabIndex = 13;
            this.gBoxVuelosInternacionales.TabStop = false;
            this.gBoxVuelosInternacionales.Text = "Vuelos Internacionales";
            // 
            // dtgVuelosInternacionales
            // 
            this.dtgVuelosInternacionales.AllowUserToAddRows = false;
            this.dtgVuelosInternacionales.AllowUserToDeleteRows = false;
            this.dtgVuelosInternacionales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVuelosInternacionales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVuelosInternacionales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgVuelosInternacionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelosInternacionales.Location = new System.Drawing.Point(6, 16);
            this.dtgVuelosInternacionales.Name = "dtgVuelosInternacionales";
            this.dtgVuelosInternacionales.ReadOnly = true;
            this.dtgVuelosInternacionales.RowHeadersVisible = false;
            this.dtgVuelosInternacionales.RowTemplate.Height = 25;
            this.dtgVuelosInternacionales.Size = new System.Drawing.Size(900, 187);
            this.dtgVuelosInternacionales.TabIndex = 8;
            this.dtgVuelosInternacionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVuelosInternacionales_CellContentClick);
            // 
            // btnMostrarVuelos
            // 
            this.btnMostrarVuelos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarVuelos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarVuelos.Location = new System.Drawing.Point(143, 492);
            this.btnMostrarVuelos.Name = "btnMostrarVuelos";
            this.btnMostrarVuelos.Size = new System.Drawing.Size(125, 34);
            this.btnMostrarVuelos.TabIndex = 14;
            this.btnMostrarVuelos.Text = "Mostrar Vuelos";
            this.btnMostrarVuelos.UseVisualStyleBackColor = false;
            this.btnMostrarVuelos.Click += new System.EventHandler(this.btnMostrarVuelos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(337, 452);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 34);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAltaVuelo
            // 
            this.btnAltaVuelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAltaVuelo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaVuelo.Location = new System.Drawing.Point(468, 452);
            this.btnAltaVuelo.Name = "btnAltaVuelo";
            this.btnAltaVuelo.Size = new System.Drawing.Size(125, 34);
            this.btnAltaVuelo.TabIndex = 16;
            this.btnAltaVuelo.Text = "Alta de Vuelo";
            this.btnAltaVuelo.UseVisualStyleBackColor = false;
            this.btnAltaVuelo.Click += new System.EventHandler(this.btnAltaVuelo_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(935, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btnAltaVuelo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrarVuelos);
            this.Controls.Add(this.gBoxVuelosInternacionales);
            this.Controls.Add(this.gboxVuelosNacionales);
            this.Controls.Add(this.dtpFechaIda);
            this.Controls.Add(this.labNombreOperador);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalir);
            this.DoubleBuffered = true;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aero Drago > Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosNacionales)).EndInit();
            this.gboxVuelosNacionales.ResumeLayout(false);
            this.gBoxVuelosInternacionales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosInternacionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private Button btnCerrarSesion;
        private Label labNombreOperador;
        private DataGridView dtgVuelosNacionales;
        private DateTimePicker dtpFechaIda;
        private GroupBox gboxVuelosNacionales;
        private GroupBox gBoxVuelosInternacionales;
        private DataGridView dtgVuelosInternacionales;
        private Button btnMostrarVuelos;
        private Button btnCerrar;
        private Button btnAltaVuelo;
    }
}