namespace Jardin
{
    partial class FrmAltaAlumno
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
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtPrecioCuotaAlumno = new System.Windows.Forms.TextBox();
            this.btnCargarAlumno = new System.Windows.Forms.Button();
            this.lblListaAlumno = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstAlumno = new System.Windows.Forms.ListView();
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFemenino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLegajo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioCuota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.txtApellidoResponsable = new System.Windows.Forms.TextBox();
            this.txtDniResponsable = new System.Windows.Forms.TextBox();
            this.txtTelefonoResponsable = new System.Windows.Forms.TextBox();
            this.cmbParentescoResponsable = new System.Windows.Forms.ComboBox();
            this.lblNResponsable = new System.Windows.Forms.Label();
            this.lblAResponsable = new System.Windows.Forms.Label();
            this.lblDniResponsable = new System.Windows.Forms.Label();
            this.lblParentResponsable = new System.Windows.Forms.Label();
            this.lblTelResponsable = new System.Windows.Forms.Label();
            this.chkFemeninoAlumno = new System.Windows.Forms.CheckBox();
            this.txtLegajoAlumno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(122, 153);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(100, 21);
            this.cmbSala.TabIndex = 54;
            this.cmbSala.SelectedIndexChanged += new System.EventHandler(this.cmbSala_SelectedIndexChanged);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(60, 245);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(65, 13);
            this.lblSalida.TabIndex = 51;
            this.lblSalida.Text = "Pecio Cuota";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(60, 206);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(39, 13);
            this.lblEntrada.TabIndex = 50;
            this.lblEntrada.Text = "Legajo";
            // 
            // txtPrecioCuotaAlumno
            // 
            this.txtPrecioCuotaAlumno.Location = new System.Drawing.Point(131, 242);
            this.txtPrecioCuotaAlumno.Name = "txtPrecioCuotaAlumno";
            this.txtPrecioCuotaAlumno.Size = new System.Drawing.Size(71, 20);
            this.txtPrecioCuotaAlumno.TabIndex = 49;
            // 
            // btnCargarAlumno
            // 
            this.btnCargarAlumno.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCargarAlumno.Location = new System.Drawing.Point(672, 411);
            this.btnCargarAlumno.Name = "btnCargarAlumno";
            this.btnCargarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnCargarAlumno.TabIndex = 47;
            this.btnCargarAlumno.Text = "Cargar";
            this.btnCargarAlumno.UseVisualStyleBackColor = true;
            this.btnCargarAlumno.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblListaAlumno
            // 
            this.lblListaAlumno.AutoSize = true;
            this.lblListaAlumno.Location = new System.Drawing.Point(239, 45);
            this.lblListaAlumno.Name = "lblListaAlumno";
            this.lblListaAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblListaAlumno.TabIndex = 46;
            this.lblListaAlumno.Text = "Alumno ";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(60, 153);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 13);
            this.lblSala.TabIndex = 45;
            this.lblSala.Text = "Sala";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(60, 127);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 44;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(60, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 43;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Text = "Nombre";
            // 
            // lstAlumno
            // 
            this.lstAlumno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colApellido,
            this.colNombre,
            this.coluDni,
            this.colFemenino,
            this.colLegajo,
            this.colPrecioCuota,
            this.colSala});
            this.lstAlumno.HideSelection = false;
            this.lstAlumno.Location = new System.Drawing.Point(242, 72);
            this.lstAlumno.Name = "lstAlumno";
            this.lstAlumno.Size = new System.Drawing.Size(505, 302);
            this.lstAlumno.TabIndex = 41;
            this.lstAlumno.UseCompatibleStateImageBehavior = false;
            this.lstAlumno.View = System.Windows.Forms.View.Details;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 96;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 71;
            // 
            // coluDni
            // 
            this.coluDni.Text = "DNI";
            this.coluDni.Width = 66;
            // 
            // colFemenino
            // 
            this.colFemenino.Text = "Femenino";
            this.colFemenino.Width = 61;
            // 
            // colLegajo
            // 
            this.colLegajo.Text = "Legajo";
            // 
            // colPrecioCuota
            // 
            this.colPrecioCuota.Text = "Pr Cuota";
            // 
            // colSala
            // 
            this.colSala.Text = "Sala";
            this.colSala.Width = 89;
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(122, 124);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtDniAlumno.TabIndex = 39;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(122, 98);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAlumno.TabIndex = 38;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(122, 72);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAlumno.TabIndex = 37;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(60, 421);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 13);
            this.lblResponsable.TabIndex = 55;
            this.lblResponsable.Text = "Responsable";
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.Location = new System.Drawing.Point(131, 417);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtNombreResponsable.TabIndex = 56;
            // 
            // txtApellidoResponsable
            // 
            this.txtApellidoResponsable.Location = new System.Drawing.Point(237, 418);
            this.txtApellidoResponsable.Name = "txtApellidoResponsable";
            this.txtApellidoResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoResponsable.TabIndex = 57;
            // 
            // txtDniResponsable
            // 
            this.txtDniResponsable.Location = new System.Drawing.Point(343, 418);
            this.txtDniResponsable.Name = "txtDniResponsable";
            this.txtDniResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtDniResponsable.TabIndex = 58;
            // 
            // txtTelefonoResponsable
            // 
            this.txtTelefonoResponsable.Location = new System.Drawing.Point(555, 417);
            this.txtTelefonoResponsable.Name = "txtTelefonoResponsable";
            this.txtTelefonoResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoResponsable.TabIndex = 60;
            // 
            // cmbParentescoResponsable
            // 
            this.cmbParentescoResponsable.FormattingEnabled = true;
            this.cmbParentescoResponsable.Location = new System.Drawing.Point(449, 416);
            this.cmbParentescoResponsable.Name = "cmbParentescoResponsable";
            this.cmbParentescoResponsable.Size = new System.Drawing.Size(100, 21);
            this.cmbParentescoResponsable.TabIndex = 61;
            // 
            // lblNResponsable
            // 
            this.lblNResponsable.AutoSize = true;
            this.lblNResponsable.Location = new System.Drawing.Point(156, 402);
            this.lblNResponsable.Name = "lblNResponsable";
            this.lblNResponsable.Size = new System.Drawing.Size(44, 13);
            this.lblNResponsable.TabIndex = 62;
            this.lblNResponsable.Text = "Nombre";
            // 
            // lblAResponsable
            // 
            this.lblAResponsable.AutoSize = true;
            this.lblAResponsable.Location = new System.Drawing.Point(261, 402);
            this.lblAResponsable.Name = "lblAResponsable";
            this.lblAResponsable.Size = new System.Drawing.Size(44, 13);
            this.lblAResponsable.TabIndex = 63;
            this.lblAResponsable.Text = "Apellido";
            // 
            // lblDniResponsable
            // 
            this.lblDniResponsable.AutoSize = true;
            this.lblDniResponsable.Location = new System.Drawing.Point(365, 402);
            this.lblDniResponsable.Name = "lblDniResponsable";
            this.lblDniResponsable.Size = new System.Drawing.Size(26, 13);
            this.lblDniResponsable.TabIndex = 64;
            this.lblDniResponsable.Text = "DNI";
            // 
            // lblParentResponsable
            // 
            this.lblParentResponsable.AutoSize = true;
            this.lblParentResponsable.Location = new System.Drawing.Point(474, 401);
            this.lblParentResponsable.Name = "lblParentResponsable";
            this.lblParentResponsable.Size = new System.Drawing.Size(61, 13);
            this.lblParentResponsable.TabIndex = 65;
            this.lblParentResponsable.Text = "Parentesco";
            // 
            // lblTelResponsable
            // 
            this.lblTelResponsable.AutoSize = true;
            this.lblTelResponsable.Location = new System.Drawing.Point(576, 402);
            this.lblTelResponsable.Name = "lblTelResponsable";
            this.lblTelResponsable.Size = new System.Drawing.Size(49, 13);
            this.lblTelResponsable.TabIndex = 66;
            this.lblTelResponsable.Text = "Teléfono";
            // 
            // chkFemeninoAlumno
            // 
            this.chkFemeninoAlumno.AutoSize = true;
            this.chkFemeninoAlumno.Location = new System.Drawing.Point(63, 286);
            this.chkFemeninoAlumno.Name = "chkFemeninoAlumno";
            this.chkFemeninoAlumno.Size = new System.Drawing.Size(72, 17);
            this.chkFemeninoAlumno.TabIndex = 67;
            this.chkFemeninoAlumno.Text = "Femenino";
            this.chkFemeninoAlumno.UseVisualStyleBackColor = true;
            // 
            // txtLegajoAlumno
            // 
            this.txtLegajoAlumno.Location = new System.Drawing.Point(131, 203);
            this.txtLegajoAlumno.Name = "txtLegajoAlumno";
            this.txtLegajoAlumno.Size = new System.Drawing.Size(71, 20);
            this.txtLegajoAlumno.TabIndex = 68;
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLegajoAlumno);
            this.Controls.Add(this.chkFemeninoAlumno);
            this.Controls.Add(this.lblTelResponsable);
            this.Controls.Add(this.lblParentResponsable);
            this.Controls.Add(this.lblDniResponsable);
            this.Controls.Add(this.lblAResponsable);
            this.Controls.Add(this.lblNResponsable);
            this.Controls.Add(this.cmbParentescoResponsable);
            this.Controls.Add(this.txtTelefonoResponsable);
            this.Controls.Add(this.txtDniResponsable);
            this.Controls.Add(this.txtApellidoResponsable);
            this.Controls.Add(this.txtNombreResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtPrecioCuotaAlumno);
            this.Controls.Add(this.btnCargarAlumno);
            this.Controls.Add(this.lblListaAlumno);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstAlumno);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Name = "FrmAltaAlumno";
            this.Text = "Alta de Alumno";
            this.Load += new System.EventHandler(this.FrmAltaAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtPrecioCuotaAlumno;
        private System.Windows.Forms.Button btnCargarAlumno;
        private System.Windows.Forms.Label lblListaAlumno;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListView lstAlumno;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader coluDni;
        private System.Windows.Forms.ColumnHeader colFemenino;
        private System.Windows.Forms.ColumnHeader colLegajo;
        private System.Windows.Forms.ColumnHeader colPrecioCuota;
        private System.Windows.Forms.ColumnHeader colSala;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.TextBox txtApellidoResponsable;
        private System.Windows.Forms.TextBox txtDniResponsable;
        private System.Windows.Forms.TextBox txtTelefonoResponsable;
        private System.Windows.Forms.ComboBox cmbParentescoResponsable;
        private System.Windows.Forms.Label lblNResponsable;
        private System.Windows.Forms.Label lblAResponsable;
        private System.Windows.Forms.Label lblDniResponsable;
        private System.Windows.Forms.Label lblParentResponsable;
        private System.Windows.Forms.Label lblTelResponsable;
        private System.Windows.Forms.CheckBox chkFemeninoAlumno;
        private System.Windows.Forms.TextBox txtLegajoAlumno;
    }
}