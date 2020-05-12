namespace Jardin
{
    partial class FrmTotalJardin
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
            this.lblRecTotalJardin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecTotalJardin
            // 
            this.lblRecTotalJardin.AutoSize = true;
            this.lblRecTotalJardin.Location = new System.Drawing.Point(12, 27);
            this.lblRecTotalJardin.Name = "lblRecTotalJardin";
            this.lblRecTotalJardin.Size = new System.Drawing.Size(35, 13);
            this.lblRecTotalJardin.TabIndex = 0;
            this.lblRecTotalJardin.Text = "label1";
            // 
            // FrmTotalJardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(278, 73);
            this.Controls.Add(this.lblRecTotalJardin);
            this.Name = "FrmTotalJardin";
            this.Text = "Recaudación Total del Jardin";
            this.Load += new System.EventHandler(this.FrmTotalJardin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecTotalJardin;
    }
}