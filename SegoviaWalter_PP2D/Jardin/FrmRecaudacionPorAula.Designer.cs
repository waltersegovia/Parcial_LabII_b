namespace Jardin
{
    partial class FrmRecaudacionPorAula
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
            this.lblRecaudacionNaranja = new System.Windows.Forms.Label();
            this.lblRecaudacionRoja = new System.Windows.Forms.Label();
            this.lblRecaudacionAmarilla = new System.Windows.Forms.Label();
            this.lblRecaudacionVerde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecaudacionNaranja
            // 
            this.lblRecaudacionNaranja.AutoSize = true;
            this.lblRecaudacionNaranja.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionNaranja.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionNaranja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRecaudacionNaranja.Location = new System.Drawing.Point(26, 38);
            this.lblRecaudacionNaranja.Name = "lblRecaudacionNaranja";
            this.lblRecaudacionNaranja.Size = new System.Drawing.Size(43, 15);
            this.lblRecaudacionNaranja.TabIndex = 0;
            this.lblRecaudacionNaranja.Text = "label1";
            // 
            // lblRecaudacionRoja
            // 
            this.lblRecaudacionRoja.AutoSize = true;
            this.lblRecaudacionRoja.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionRoja.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionRoja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecaudacionRoja.Location = new System.Drawing.Point(26, 68);
            this.lblRecaudacionRoja.Name = "lblRecaudacionRoja";
            this.lblRecaudacionRoja.Size = new System.Drawing.Size(43, 15);
            this.lblRecaudacionRoja.TabIndex = 1;
            this.lblRecaudacionRoja.Text = "label2";
            // 
            // lblRecaudacionAmarilla
            // 
            this.lblRecaudacionAmarilla.AutoSize = true;
            this.lblRecaudacionAmarilla.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionAmarilla.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionAmarilla.ForeColor = System.Drawing.Color.Yellow;
            this.lblRecaudacionAmarilla.Location = new System.Drawing.Point(26, 97);
            this.lblRecaudacionAmarilla.Name = "lblRecaudacionAmarilla";
            this.lblRecaudacionAmarilla.Size = new System.Drawing.Size(43, 15);
            this.lblRecaudacionAmarilla.TabIndex = 2;
            this.lblRecaudacionAmarilla.Text = "label3";
            // 
            // lblRecaudacionVerde
            // 
            this.lblRecaudacionVerde.AutoSize = true;
            this.lblRecaudacionVerde.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionVerde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRecaudacionVerde.Location = new System.Drawing.Point(26, 127);
            this.lblRecaudacionVerde.Name = "lblRecaudacionVerde";
            this.lblRecaudacionVerde.Size = new System.Drawing.Size(43, 15);
            this.lblRecaudacionVerde.TabIndex = 3;
            this.lblRecaudacionVerde.Text = "label4";
            // 
            // FrmRecaudacionPorAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Jardin.Properties.Resources.Jardín_7;
            this.ClientSize = new System.Drawing.Size(308, 175);
            this.Controls.Add(this.lblRecaudacionVerde);
            this.Controls.Add(this.lblRecaudacionAmarilla);
            this.Controls.Add(this.lblRecaudacionRoja);
            this.Controls.Add(this.lblRecaudacionNaranja);
            this.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRecaudacionPorAula";
            this.Text = "Recaudacion Por Aula";
            this.Load += new System.EventHandler(this.FrmRecaudacionPorAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecaudacionNaranja;
        private System.Windows.Forms.Label lblRecaudacionRoja;
        private System.Windows.Forms.Label lblRecaudacionAmarilla;
        private System.Windows.Forms.Label lblRecaudacionVerde;
    }
}