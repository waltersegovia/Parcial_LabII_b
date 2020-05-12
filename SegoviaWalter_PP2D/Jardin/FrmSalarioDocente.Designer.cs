namespace Jardin
{
    partial class FrmSalarioDocente
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
            this.lblSalarioDocente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalarioDocente
            // 
            this.lblSalarioDocente.AutoSize = true;
            this.lblSalarioDocente.Location = new System.Drawing.Point(27, 24);
            this.lblSalarioDocente.Name = "lblSalarioDocente";
            this.lblSalarioDocente.Size = new System.Drawing.Size(35, 13);
            this.lblSalarioDocente.TabIndex = 0;
            this.lblSalarioDocente.Text = "label1";
            // 
            // FrmSalarioDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(345, 68);
            this.Controls.Add(this.lblSalarioDocente);
            this.Name = "FrmSalarioDocente";
            this.Text = "Salario Docente";
            this.Load += new System.EventHandler(this.FrmSalarioDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioDocente;
    }
}