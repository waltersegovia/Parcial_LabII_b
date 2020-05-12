namespace Jardin
{
    partial class FrmAltaNoDocente
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
            this.lblHoraSalidda = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtHoraSalidaNoDocente = new System.Windows.Forms.TextBox();
            this.txtHoraEntradaNoDocente = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblListaNoDocente = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFemenino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoraSalida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDniNoDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoNoDocente = new System.Windows.Forms.TextBox();
            this.txtNombreNoDocente = new System.Windows.Forms.TextBox();
            this.cmbCargoNoDocente = new System.Windows.Forms.ComboBox();
            this.chkFemeninoNoDocente = new System.Windows.Forms.CheckBox();
            this.btnSalirNoDocente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoraSalidda
            // 
            this.lblHoraSalidda.AutoSize = true;
            this.lblHoraSalidda.Location = new System.Drawing.Point(115, 222);
            this.lblHoraSalidda.Name = "lblHoraSalidda";
            this.lblHoraSalidda.Size = new System.Drawing.Size(44, 13);
            this.lblHoraSalidda.TabIndex = 35;
            this.lblHoraSalidda.Text = "HH:MM";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(115, 183);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblHoraEntrada.TabIndex = 34;
            this.lblHoraEntrada.Text = "HH:MM";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(51, 241);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 33;
            this.lblSalida.Text = "Salida";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(51, 202);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 32;
            this.lblEntrada.Text = "Entrada";
            // 
            // txtHoraSalidaNoDocente
            // 
            this.txtHoraSalidaNoDocente.Location = new System.Drawing.Point(113, 238);
            this.txtHoraSalidaNoDocente.Name = "txtHoraSalidaNoDocente";
            this.txtHoraSalidaNoDocente.Size = new System.Drawing.Size(52, 20);
            this.txtHoraSalidaNoDocente.TabIndex = 31;
            // 
            // txtHoraEntradaNoDocente
            // 
            this.txtHoraEntradaNoDocente.Location = new System.Drawing.Point(113, 199);
            this.txtHoraEntradaNoDocente.Name = "txtHoraEntradaNoDocente";
            this.txtHoraEntradaNoDocente.Size = new System.Drawing.Size(52, 20);
            this.txtHoraEntradaNoDocente.TabIndex = 30;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(54, 347);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 29;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblListaNoDocente
            // 
            this.lblListaNoDocente.AutoSize = true;
            this.lblListaNoDocente.Location = new System.Drawing.Point(230, 43);
            this.lblListaNoDocente.Name = "lblListaNoDocente";
            this.lblListaNoDocente.Size = new System.Drawing.Size(70, 13);
            this.lblListaNoDocente.TabIndex = 28;
            this.lblListaNoDocente.Text = "No Docentes";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(51, 149);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 27;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(51, 123);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 26;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(51, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colApellido,
            this.colNombre,
            this.coluDni,
            this.colFemenino,
            this.colHoraEntrada,
            this.colHoraSalida,
            this.colCargo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(233, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 302);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // colCargo
            // 
            this.colCargo.Text = "Cargo";
            this.colCargo.Width = 89;
            // 
            // txtDniNoDocente
            // 
            this.txtDniNoDocente.Location = new System.Drawing.Point(113, 120);
            this.txtDniNoDocente.Name = "txtDniNoDocente";
            this.txtDniNoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtDniNoDocente.TabIndex = 20;
            // 
            // txtApellidoNoDocente
            // 
            this.txtApellidoNoDocente.Location = new System.Drawing.Point(113, 94);
            this.txtApellidoNoDocente.Name = "txtApellidoNoDocente";
            this.txtApellidoNoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoNoDocente.TabIndex = 19;
            // 
            // txtNombreNoDocente
            // 
            this.txtNombreNoDocente.Location = new System.Drawing.Point(113, 68);
            this.txtNombreNoDocente.Name = "txtNombreNoDocente";
            this.txtNombreNoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreNoDocente.TabIndex = 18;
            // 
            // cmbCargoNoDocente
            // 
            this.cmbCargoNoDocente.FormattingEnabled = true;
            this.cmbCargoNoDocente.Location = new System.Drawing.Point(113, 149);
            this.cmbCargoNoDocente.Name = "cmbCargoNoDocente";
            this.cmbCargoNoDocente.Size = new System.Drawing.Size(100, 21);
            this.cmbCargoNoDocente.TabIndex = 36;
            // 
            // chkFemeninoNoDocente
            // 
            this.chkFemeninoNoDocente.AutoSize = true;
            this.chkFemeninoNoDocente.Location = new System.Drawing.Point(54, 277);
            this.chkFemeninoNoDocente.Name = "chkFemeninoNoDocente";
            this.chkFemeninoNoDocente.Size = new System.Drawing.Size(72, 17);
            this.chkFemeninoNoDocente.TabIndex = 37;
            this.chkFemeninoNoDocente.Text = "Femenino";
            this.chkFemeninoNoDocente.UseVisualStyleBackColor = true;
            // 
            // btnSalirNoDocente
            // 
            this.btnSalirNoDocente.Location = new System.Drawing.Point(663, 379);
            this.btnSalirNoDocente.Name = "btnSalirNoDocente";
            this.btnSalirNoDocente.Size = new System.Drawing.Size(75, 23);
            this.btnSalirNoDocente.TabIndex = 38;
            this.btnSalirNoDocente.Text = "Salir";
            this.btnSalirNoDocente.UseVisualStyleBackColor = true;
            this.btnSalirNoDocente.Click += new System.EventHandler(this.btnSalirNoDocente_Click);
            // 
            // FrmAltaNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(765, 414);
            this.Controls.Add(this.btnSalirNoDocente);
            this.Controls.Add(this.chkFemeninoNoDocente);
            this.Controls.Add(this.cmbCargoNoDocente);
            this.Controls.Add(this.lblHoraSalidda);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtHoraSalidaNoDocente);
            this.Controls.Add(this.txtHoraEntradaNoDocente);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblListaNoDocente);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtDniNoDocente);
            this.Controls.Add(this.txtApellidoNoDocente);
            this.Controls.Add(this.txtNombreNoDocente);
            this.Name = "FrmAltaNoDocente";
            this.Text = "Alta no Docente";
            this.Load += new System.EventHandler(this.FrmAltaNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoraSalidda;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtHoraSalidaNoDocente;
        private System.Windows.Forms.TextBox txtHoraEntradaNoDocente;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblListaNoDocente;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader coluDni;
        private System.Windows.Forms.ColumnHeader colFemenino;
        private System.Windows.Forms.ColumnHeader colHoraEntrada;
        private System.Windows.Forms.ColumnHeader colHoraSalida;
        private System.Windows.Forms.ColumnHeader colCargo;
        private System.Windows.Forms.TextBox txtDniNoDocente;
        private System.Windows.Forms.TextBox txtApellidoNoDocente;
        private System.Windows.Forms.TextBox txtNombreNoDocente;
        private System.Windows.Forms.ComboBox cmbCargoNoDocente;
        private System.Windows.Forms.CheckBox chkFemeninoNoDocente;
        private System.Windows.Forms.Button btnSalirNoDocente;
    }
}