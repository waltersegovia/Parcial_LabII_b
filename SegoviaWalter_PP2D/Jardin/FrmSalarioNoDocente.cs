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
    public partial class FrmSalarioNoDocente : Form
    {
        private List<Administrativo> administrativos;

        public FrmSalarioNoDocente(List<Administrativo> listaNoDocente)
        {
            InitializeComponent();

            this.administrativos = listaNoDocente;
        }

        private void FrmSalarioNoDocente_Load(object sender, EventArgs e)
        {
            lblSalarioNoDocente.Text = string.Empty;
            double sueldoNoDocente = 0;
            foreach (Administrativo item in administrativos)
            {
                sueldoNoDocente += item.Salario;
            }

            lblSalarioNoDocente.Text = "Total Salario: $" + sueldoNoDocente.ToString();
        }
    }
}
