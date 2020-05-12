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
    public partial class FrmTotalJardin : Form
    {
        private List<Alumno> alumnosEnSala;

        public FrmTotalJardin(List<Alumno> alumnosEnSala)
        {
            InitializeComponent();

            this.alumnosEnSala = alumnosEnSala;
        }

        private void FrmTotalJardin_Load(object sender, EventArgs e)
        {
            lblRecTotalJardin.Text = string.Empty;

            double recTotalJardin = 0;
            foreach (Alumno item in alumnosEnSala)
            {
                recTotalJardin += item.PrecioCuota;
            }

            lblRecTotalJardin.Text = "Recaudación Total: $" + recTotalJardin.ToString();
        }
    }
}
