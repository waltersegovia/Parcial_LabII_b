namespace Jardin
{
    partial class FrmSalarioNoDocente
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
            this.lblSalarioNoDocente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalarioNoDocente
            // 
            this.lblSalarioNoDocente.AutoSize = true;
            this.lblSalarioNoDocente.Location = new System.Drawing.Point(12, 36);
            this.lblSalarioNoDocente.Name = "lblSalarioNoDocente";
            this.lblSalarioNoDocente.Size = new System.Drawing.Size(35, 13);
            this.lblSalarioNoDocente.TabIndex = 0;
            this.lblSalarioNoDocente.Text = "label1";
            // 
            // FrmSalarioNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(285, 74);
            this.Controls.Add(this.lblSalarioNoDocente);
            this.Name = "FrmSalarioNoDocente";
            this.Text = "Salario No Docente";
            this.Load += new System.EventHandler(this.FrmSalarioNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioNoDocente;
    }
}