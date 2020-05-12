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
    public partial class FrmAltaNoDocente : Form
    {
        private Administrativo admnistrativo;

        public FrmAltaNoDocente()
        {
            InitializeComponent();
        }

        private void FrmAltaNoDocente_Load(object sender, EventArgs e)
        {
            foreach (int i in Enum.GetValues(typeof(ECargo)))
                cmbCargoNoDocente.Items.Add((ECargo)i);
        }

        public Administrativo NoDocente { get { return this.admnistrativo; } }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDniNoDocente.Text, out int dniAux) && DateTime.TryParse(txtHoraEntradaNoDocente.Text, out DateTime HoraEntAux) && DateTime.TryParse(txtHoraSalidaNoDocente.Text, out DateTime HoraSalAux))
            {
                admnistrativo = new Administrativo(txtApellidoNoDocente.Text, txtNombreNoDocente.Text, dniAux, chkFemeninoNoDocente.Checked, HoraEntAux, HoraSalAux, (ECargo)Enum.Parse(typeof(ECargo), cmbCargoNoDocente.Text));
                MessageBox.Show("Carga Exitosa");
            }

            else
            {
                MessageBox.Show("Error!!Revise los datos");
            }

            txtApellidoNoDocente.Text = string.Empty;
            txtDniNoDocente.Text = string.Empty;
            txtHoraEntradaNoDocente.Text = string.Empty;
            txtHoraSalidaNoDocente.Text = string.Empty;
            txtNombreNoDocente.Text = string.Empty;
           
        }

        private void btnSalirNoDocente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
