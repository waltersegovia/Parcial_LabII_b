using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Jardin
{
    public partial class FrmInformacionDePadres : Form
    {
        private List<Alumno> alumnosEnSala;

        public FrmInformacionDePadres(List<Alumno>alumnosEnSala)
        {
            InitializeComponent();

            this.alumnosEnSala = alumnosEnSala;
        }

        private void informacionDePadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Alumno item in alumnosEnSala)
            {
                rtbInfoPadres.AppendText(item.Responsable.ToString()+"\n");
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
