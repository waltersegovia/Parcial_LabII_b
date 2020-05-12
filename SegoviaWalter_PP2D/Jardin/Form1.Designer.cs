namespace Jardin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformacionDePadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónTotalDelJardínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.cargarJardinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAlulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDocenteToolStripMenuItem
            // 
            this.altaDocenteToolStripMenuItem.Name = "altaDocenteToolStripMenuItem";
            this.altaDocenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.altaDocenteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.altaDocenteToolStripMenuItem.Text = "Alta Docente";
            this.altaDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta No Docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAlulaToolStripMenuItem
            // 
            this.altaAlulaToolStripMenuItem.Name = "altaAlulaToolStripMenuItem";
            this.altaAlulaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.altaAlulaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.altaAlulaToolStripMenuItem.Text = "Alta Alula";
            this.altaAlulaToolStripMenuItem.Click += new System.EventHandler(this.altaAlulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformacionDePadresToolStripMenuItem,
            this.recaudaciónNoDocenteToolStripMenuItem,
            this.recaudaciónToolStripMenuItem,
            this.recaudaciónToolStripMenuItem1,
            this.recaudaciónTotalDelJardínToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // InformacionDePadresToolStripMenuItem
            // 
            this.InformacionDePadresToolStripMenuItem.Name = "InformacionDePadresToolStripMenuItem";
            this.InformacionDePadresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.InformacionDePadresToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.InformacionDePadresToolStripMenuItem.Text = "Información Padres";
            this.InformacionDePadresToolStripMenuItem.Click += new System.EventHandler(this.informacionDePadresToolStripMenuItem_Click);
            // 
            // recaudaciónNoDocenteToolStripMenuItem
            // 
            this.recaudaciónNoDocenteToolStripMenuItem.Name = "recaudaciónNoDocenteToolStripMenuItem";
            this.recaudaciónNoDocenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.recaudaciónNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.recaudaciónNoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            this.recaudaciónNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.recaudaciónNoDocenteToolStripMenuItem_Click);
            // 
            // recaudaciónToolStripMenuItem
            // 
            this.recaudaciónToolStripMenuItem.Name = "recaudaciónToolStripMenuItem";
            this.recaudaciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.recaudaciónToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.recaudaciónToolStripMenuItem.Text = "Sueldo no Docente";
            this.recaudaciónToolStripMenuItem.Click += new System.EventHandler(this.recaudaciónToolStripMenuItem_Click);
            // 
            // recaudaciónToolStripMenuItem1
            // 
            this.recaudaciónToolStripMenuItem1.Name = "recaudaciónToolStripMenuItem1";
            this.recaudaciónToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.recaudaciónToolStripMenuItem1.Size = new System.Drawing.Size(260, 22);
            this.recaudaciónToolStripMenuItem1.Text = "Recuadación por Aula";
            this.recaudaciónToolStripMenuItem1.Click += new System.EventHandler(this.recaudaciónToolStripMenuItem1_Click);
            // 
            // recaudaciónTotalDelJardínToolStripMenuItem
            // 
            this.recaudaciónTotalDelJardínToolStripMenuItem.Name = "recaudaciónTotalDelJardínToolStripMenuItem";
            this.recaudaciónTotalDelJardínToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.recaudaciónTotalDelJardínToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.recaudaciónTotalDelJardínToolStripMenuItem.Text = "Recaudación total del Jardín";
            this.recaudaciónTotalDelJardínToolStripMenuItem.Click += new System.EventHandler(this.recaudaciónTotalDelJardínToolStripMenuItem_Click);
            // 
            // cargarJardinToolStripMenuItem
            // 
            this.cargarJardinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDePersonalToolStripMenuItem});
            this.cargarJardinToolStripMenuItem.Name = "cargarJardinToolStripMenuItem";
            this.cargarJardinToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cargarJardinToolStripMenuItem.Text = "Cargar Jardin";
            // 
            // cargaDePersonalToolStripMenuItem
            // 
            this.cargaDePersonalToolStripMenuItem.Name = "cargaDePersonalToolStripMenuItem";
            this.cargaDePersonalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargaDePersonalToolStripMenuItem.Text = "Carga de Personal";
            this.cargaDePersonalToolStripMenuItem.Click += new System.EventHandler(this.cargaDePersonalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 515);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jardín de Infantes \"Los Pichoncitos\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformacionDePadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónTotalDelJardínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarJardinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDePersonalToolStripMenuItem;
    }
}

