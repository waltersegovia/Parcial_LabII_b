namespace Jardin
{
    partial class FrmAltaAula
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
            this.cmbColorAltaAula = new System.Windows.Forms.ComboBox();
            this.cmbTurnoAltaAula = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lstvAlumnosSinAula = new System.Windows.Forms.ListView();
            this.colLegajo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColorSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFemenino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioCuota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvAlumnosEnSala = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAlumnosSinAula = new System.Windows.Forms.Label();
            this.lblAlumnosEnSala = new System.Windows.Forms.Label();
            this.btnAsignarAlumnoASala = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearAula = new System.Windows.Forms.Button();
            this.grbAula = new System.Windows.Forms.GroupBox();
            this.lblColorSalaAula = new System.Windows.Forms.Label();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.grbAula.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbColorAltaAula
            // 
            this.cmbColorAltaAula.FormattingEnabled = true;
            this.cmbColorAltaAula.Location = new System.Drawing.Point(25, 32);
            this.cmbColorAltaAula.Name = "cmbColorAltaAula";
            this.cmbColorAltaAula.Size = new System.Drawing.Size(149, 25);
            this.cmbColorAltaAula.TabIndex = 0;
            this.cmbColorAltaAula.SelectedIndexChanged += new System.EventHandler(this.cmbColorAltaAula_SelectedIndexChanged);
            // 
            // cmbTurnoAltaAula
            // 
            this.cmbTurnoAltaAula.FormattingEnabled = true;
            this.cmbTurnoAltaAula.Location = new System.Drawing.Point(180, 32);
            this.cmbTurnoAltaAula.Name = "cmbTurnoAltaAula";
            this.cmbTurnoAltaAula.Size = new System.Drawing.Size(149, 25);
            this.cmbTurnoAltaAula.TabIndex = 1;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(335, 32);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(149, 25);
            this.cmbProfesor.TabIndex = 2;
            this.cmbProfesor.SelectedIndexChanged += new System.EventHandler(this.cmbProfesor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(82, 12);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 17);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Sala";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(230, 12);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(41, 17);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(377, 12);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(54, 17);
            this.lblProfesor.TabIndex = 5;
            this.lblProfesor.Text = "Profesor";
            // 
            // lstvAlumnosSinAula
            // 
            this.lstvAlumnosSinAula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLegajo,
            this.colApellido,
            this.colNombre,
            this.colDni,
            this.colColorSala,
            this.colFemenino,
            this.colPrecioCuota});
            this.lstvAlumnosSinAula.HideSelection = false;
            this.lstvAlumnosSinAula.Location = new System.Drawing.Point(15, 104);
            this.lstvAlumnosSinAula.Name = "lstvAlumnosSinAula";
            this.lstvAlumnosSinAula.Size = new System.Drawing.Size(453, 306);
            this.lstvAlumnosSinAula.TabIndex = 6;
            this.lstvAlumnosSinAula.UseCompatibleStateImageBehavior = false;
            this.lstvAlumnosSinAula.View = System.Windows.Forms.View.Details;
            this.lstvAlumnosSinAula.SelectedIndexChanged += new System.EventHandler(this.lstvAlumnosSinAula_SelectedIndexChanged);
            // 
            // colLegajo
            // 
            this.colLegajo.Text = "Legajo";
            this.colLegajo.Width = 52;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 75;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            // 
            // colColorSala
            // 
            this.colColorSala.Text = "Sala";
            this.colColorSala.Width = 54;
            // 
            // colFemenino
            // 
            this.colFemenino.Text = "Femenino";
            this.colFemenino.Width = 69;
            // 
            // colPrecioCuota
            // 
            this.colPrecioCuota.Text = "Cuota";
            // 
            // lstvAlumnosEnSala
            // 
            this.lstvAlumnosEnSala.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstvAlumnosEnSala.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstvAlumnosEnSala.HideSelection = false;
            this.lstvAlumnosEnSala.Location = new System.Drawing.Point(474, 104);
            this.lstvAlumnosEnSala.Name = "lstvAlumnosEnSala";
            this.lstvAlumnosEnSala.Size = new System.Drawing.Size(433, 306);
            this.lstvAlumnosEnSala.TabIndex = 7;
            this.lstvAlumnosEnSala.UseCompatibleStateImageBehavior = false;
            this.lstvAlumnosEnSala.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Legajo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DNI";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sala";
            this.columnHeader5.Width = 52;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Femenino";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cuota";
            this.columnHeader7.Width = 72;
            // 
            // lblAlumnosSinAula
            // 
            this.lblAlumnosSinAula.AutoSize = true;
            this.lblAlumnosSinAula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosSinAula.Location = new System.Drawing.Point(12, 80);
            this.lblAlumnosSinAula.Name = "lblAlumnosSinAula";
            this.lblAlumnosSinAula.Size = new System.Drawing.Size(105, 15);
            this.lblAlumnosSinAula.TabIndex = 8;
            this.lblAlumnosSinAula.Text = "Alumnos sin Aula";
            // 
            // lblAlumnosEnSala
            // 
            this.lblAlumnosEnSala.AutoSize = true;
            this.lblAlumnosEnSala.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosEnSala.Location = new System.Drawing.Point(471, 83);
            this.lblAlumnosEnSala.Name = "lblAlumnosEnSala";
            this.lblAlumnosEnSala.Size = new System.Drawing.Size(102, 15);
            this.lblAlumnosEnSala.TabIndex = 9;
            this.lblAlumnosEnSala.Text = "Alumnos en Sala";
            // 
            // btnAsignarAlumnoASala
            // 
            this.btnAsignarAlumnoASala.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAsignarAlumnoASala.Location = new System.Drawing.Point(812, 415);
            this.btnAsignarAlumnoASala.Name = "btnAsignarAlumnoASala";
            this.btnAsignarAlumnoASala.Size = new System.Drawing.Size(95, 23);
            this.btnAsignarAlumnoASala.TabIndex = 10;
            this.btnAsignarAlumnoASala.Text = "Asignar Sala";
            this.btnAsignarAlumnoASala.UseVisualStyleBackColor = true;
            this.btnAsignarAlumnoASala.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearAula
            // 
            this.btnCrearAula.Location = new System.Drawing.Point(529, 30);
            this.btnCrearAula.Name = "btnCrearAula";
            this.btnCrearAula.Size = new System.Drawing.Size(75, 23);
            this.btnCrearAula.TabIndex = 12;
            this.btnCrearAula.Text = "Crear Aula";
            this.btnCrearAula.UseVisualStyleBackColor = true;
            this.btnCrearAula.Click += new System.EventHandler(this.btnCrearAula_Click);
            // 
            // grbAula
            // 
            this.grbAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbAula.Controls.Add(this.btnCrearAula);
            this.grbAula.Controls.Add(this.lblProfesor);
            this.grbAula.Controls.Add(this.lblTurno);
            this.grbAula.Controls.Add(this.lblColor);
            this.grbAula.Controls.Add(this.cmbProfesor);
            this.grbAula.Controls.Add(this.cmbTurnoAltaAula);
            this.grbAula.Controls.Add(this.cmbColorAltaAula);
            this.grbAula.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAula.Location = new System.Drawing.Point(11, 1);
            this.grbAula.Name = "grbAula";
            this.grbAula.Size = new System.Drawing.Size(621, 79);
            this.grbAula.TabIndex = 13;
            this.grbAula.TabStop = false;
            this.grbAula.Text = "Aula";
            // 
            // lblColorSalaAula
            // 
            this.lblColorSalaAula.AutoSize = true;
            this.lblColorSalaAula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSalaAula.Location = new System.Drawing.Point(574, 83);
            this.lblColorSalaAula.Name = "lblColorSalaAula";
            this.lblColorSalaAula.Size = new System.Drawing.Size(41, 15);
            this.lblColorSalaAula.TabIndex = 14;
            this.lblColorSalaAula.Text = "label1";
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocente.Location = new System.Drawing.Point(647, 83);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(41, 15);
            this.lblNombreDocente.TabIndex = 15;
            this.lblNombreDocente.Text = "label2";
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.lblNombreDocente);
            this.Controls.Add(this.lblColorSalaAula);
            this.Controls.Add(this.grbAula);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignarAlumnoASala);
            this.Controls.Add(this.lblAlumnosEnSala);
            this.Controls.Add(this.lblAlumnosSinAula);
            this.Controls.Add(this.lstvAlumnosEnSala);
            this.Controls.Add(this.lstvAlumnosSinAula);
            this.Name = "FrmAltaAula";
            this.Text = "Asignacion de Sala";
            this.Load += new System.EventHandler(this.AltaAula_Load);
            this.grbAula.ResumeLayout(false);
            this.grbAula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColorAltaAula;
        private System.Windows.Forms.ComboBox cmbTurnoAltaAula;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ListView lstvAlumnosSinAula;
        private System.Windows.Forms.ListView lstvAlumnosEnSala;
        private System.Windows.Forms.Label lblAlumnosSinAula;
        private System.Windows.Forms.Label lblAlumnosEnSala;
        private System.Windows.Forms.Button btnAsignarAlumnoASala;
        private System.Windows.Forms.ColumnHeader colLegajo;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colDni;
        private System.Windows.Forms.ColumnHeader colColorSala;
        private System.Windows.Forms.ColumnHeader colFemenino;
        private System.Windows.Forms.ColumnHeader colPrecioCuota;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearAula;
        private System.Windows.Forms.GroupBox grbAula;
        private System.Windows.Forms.Label lblColorSalaAula;
        private System.Windows.Forms.Label lblNombreDocente;
    }
}