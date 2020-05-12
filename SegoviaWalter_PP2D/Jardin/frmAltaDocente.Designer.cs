namespace Jardin
{
    partial class FrmAltaDocente
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
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoDocente = new System.Windows.Forms.TextBox();
            this.txtDniDocente = new System.Windows.Forms.TextBox();
            this.txtValorHoraDocente = new System.Windows.Forms.TextBox();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.chkFemeninoDocente = new System.Windows.Forms.CheckBox();
            this.lstvProfesores = new System.Windows.Forms.ListView();
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFemenino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoraSalida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValorHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblListaProfesores = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalidda = new System.Windows.Forms.Label();
            this.btnSalirProfesor = new System.Windows.Forms.Button();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(96, 37);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDocente.TabIndex = 0;
            // 
            // txtApellidoDocente
            // 
            this.txtApellidoDocente.Location = new System.Drawing.Point(96, 63);
            this.txtApellidoDocente.Name = "txtApellidoDocente";
            this.txtApellidoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoDocente.TabIndex = 1;
            // 
            // txtDniDocente
            // 
            this.txtDniDocente.Location = new System.Drawing.Point(96, 89);
            this.txtDniDocente.Name = "txtDniDocente";
            this.txtDniDocente.Size = new System.Drawing.Size(100, 20);
            this.txtDniDocente.TabIndex = 2;
            // 
            // txtValorHoraDocente
            // 
            this.txtValorHoraDocente.Location = new System.Drawing.Point(96, 115);
            this.txtValorHoraDocente.Name = "txtValorHoraDocente";
            this.txtValorHoraDocente.Size = new System.Drawing.Size(100, 20);
            this.txtValorHoraDocente.TabIndex = 3;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.chkFemeninoDocente);
            this.grbSexo.Location = new System.Drawing.Point(27, 239);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(121, 51);
            this.grbSexo.TabIndex = 4;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // chkFemeninoDocente
            // 
            this.chkFemeninoDocente.AutoSize = true;
            this.chkFemeninoDocente.Location = new System.Drawing.Point(10, 19);
            this.chkFemeninoDocente.Name = "chkFemeninoDocente";
            this.chkFemeninoDocente.Size = new System.Drawing.Size(72, 17);
            this.chkFemeninoDocente.TabIndex = 0;
            this.chkFemeninoDocente.Text = "Femenino";
            this.chkFemeninoDocente.UseVisualStyleBackColor = true;
            // 
            // lstvProfesores
            // 
            this.lstvProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colApellido,
            this.colNombre,
            this.coluDni,
            this.colFemenino,
            this.colHoraEntrada,
            this.colHoraSalida,
            this.colValorHora});
            this.lstvProfesores.HideSelection = false;
            this.lstvProfesores.Location = new System.Drawing.Point(235, 37);
            this.lstvProfesores.Name = "lstvProfesores";
            this.lstvProfesores.Size = new System.Drawing.Size(505, 302);
            this.lstvProfesores.TabIndex = 5;
            this.lstvProfesores.UseCompatibleStateImageBehavior = false;
            this.lstvProfesores.View = System.Windows.Forms.View.Details;
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
            // colHoraEntrada
            // 
            this.colHoraEntrada.Text = "H Entrada";
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.Text = "H Salida";
            // 
            // colValorHora
            // 
            this.colValorHora.Text = "Valor Hora";
            this.colValorHora.Width = 89;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(34, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(34, 92);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(34, 118);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(64, 13);
            this.lblValorHora.TabIndex = 9;
            this.lblValorHora.Text = "Valor hora $";
            // 
            // lblListaProfesores
            // 
            this.lblListaProfesores.AutoSize = true;
            this.lblListaProfesores.Location = new System.Drawing.Point(232, 9);
            this.lblListaProfesores.Name = "lblListaProfesores";
            this.lblListaProfesores.Size = new System.Drawing.Size(97, 13);
            this.lblListaProfesores.TabIndex = 10;
            this.lblListaProfesores.Text = "Lista de Profesores";
            // 
            // btnCargar
            // 
            this.btnCargar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCargar.Location = new System.Drawing.Point(34, 296);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(96, 168);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(52, 20);
            this.txtHoraEntrada.TabIndex = 12;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(96, 207);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(52, 20);
            this.txtHoraSalida.TabIndex = 13;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(34, 171);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 14;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(34, 210);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 15;
            this.lblSalida.Text = "Salida";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(98, 152);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblHoraEntrada.TabIndex = 16;
            this.lblHoraEntrada.Text = "HH:MM";
            // 
            // lblHoraSalidda
            // 
            this.lblHoraSalidda.AutoSize = true;
            this.lblHoraSalidda.Location = new System.Drawing.Point(98, 191);
            this.lblHoraSalidda.Name = "lblHoraSalidda";
            this.lblHoraSalidda.Size = new System.Drawing.Size(44, 13);
            this.lblHoraSalidda.TabIndex = 17;
            this.lblHoraSalidda.Text = "HH:MM";
            // 
            // btnSalirProfesor
            // 
            this.btnSalirProfesor.Location = new System.Drawing.Point(665, 361);
            this.btnSalirProfesor.Name = "btnSalirProfesor";
            this.btnSalirProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnSalirProfesor.TabIndex = 18;
            this.btnSalirProfesor.Text = "Salir";
            this.btnSalirProfesor.UseVisualStyleBackColor = true;
            this.btnSalirProfesor.Click += new System.EventHandler(this.btnSalirProfesor_Click);
            // 
            // FrmAltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(752, 396);
            this.Controls.Add(this.btnSalirProfesor);
            this.Controls.Add(this.lblHoraSalidda);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblListaProfesores);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstvProfesores);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.txtValorHoraDocente);
            this.Controls.Add(this.txtDniDocente);
            this.Controls.Add(this.txtApellidoDocente);
            this.Controls.Add(this.txtNombreDocente);
            this.Name = "FrmAltaDocente";
            this.Text = "Alta Docente";
            this.Load += new System.EventHandler(this.FrmAltaDocente_Load);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtApellidoDocente;
        private System.Windows.Forms.TextBox txtDniDocente;
        private System.Windows.Forms.TextBox txtValorHoraDocente;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.ListView lstvProfesores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.Label lblListaProfesores;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalidda;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader coluDni;
        private System.Windows.Forms.ColumnHeader colFemenino;
        private System.Windows.Forms.ColumnHeader colHoraEntrada;
        private System.Windows.Forms.ColumnHeader colHoraSalida;
        private System.Windows.Forms.ColumnHeader colValorHora;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.CheckBox chkFemeninoDocente;
        private System.Windows.Forms.Button btnSalirProfesor;
    }
}