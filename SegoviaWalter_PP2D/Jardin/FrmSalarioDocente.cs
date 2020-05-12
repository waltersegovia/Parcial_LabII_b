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
    public partial class FrmSalarioDocente : Form
    {
        private List<Docente> docentes;

        public FrmSalarioDocente(List<Docente> docentes)
        {
            InitializeComponent();

            this.docentes = docentes;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmSalarioDocente_Load(object sender, EventArgs e)
        {
            lblSalarioDocente.Text = string.Empty;
            double salarioDocente = 0;
            foreach (Docente item in this.docentes)
            {
                salarioDocente += item.Salario;
            }

            lblSalarioDocente.Text = "Total de Salario: $" + salarioDocente.ToString();
        }
    }
    
}
