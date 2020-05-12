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
    public partial class FrmAltaDocente : Form
    {
        private Docente docente;
        private List<Docente> listaDocentes;

        public FrmAltaDocente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {
            listaDocentes = new List<Docente>();
        }


        public List<Docente> ListaDocentes
        {
            get { return this.listaDocentes; }
        }

        public Docente Docente
        {
            get { return this.docente; }
        }

        /// <summary>
        /// Boton Cargar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDniDocente.Text, out int dniAux) && DateTime.TryParse(txtHoraEntrada.Text, out DateTime HoraEntAux) && DateTime.TryParse(txtHoraSalida.Text, out DateTime HoraSalAux) && float.TryParse(txtValorHoraDocente.Text, out float valorHoraAux))
            {
                docente = new Docente(txtNombreDocente.Text, txtApellidoDocente.Text, dniAux,chkFemeninoDocente.Checked,HoraEntAux,HoraSalAux,valorHoraAux);
                listaDocentes.Add(docente);
                MessageBox.Show("Carga Exitosa");
            }

            else
            {
                MessageBox.Show("Error!!Revise los datos");
            }

            txtApellidoDocente.Text = string.Empty;
            txtDniDocente.Text = string.Empty;
            txtHoraEntrada.Text = string.Empty;
            txtHoraSalida.Text = string.Empty;
            txtNombreDocente.Text = string.Empty;
            txtValorHoraDocente.Text = string.Empty;
      
        }

        private void btnSalirProfesor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
