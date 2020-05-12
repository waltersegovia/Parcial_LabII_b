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
    public partial class FrmAltaAlumno : Form
    { 
        private Alumno alumno;
        private Responsable responsable;
        //string comboMensaje;
        //private Aula aula;

        /// <summary>
        /// Peopiedad de Alumno
        /// </summary>
        public Alumno Alumno
        {
            get { return this.alumno; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
        }

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load. Carga los ComboBox con los Enum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            //aula = new Aula();

            foreach (int i in Enum.GetValues(typeof(EColores)))
                cmbSala.Items.Add((EColores)i);

            foreach (int i in Enum.GetValues(typeof(EParentesco)))
                cmbParentescoResponsable.Items.Add((EParentesco)i);
        }

        /// <summary>
        /// Botón Cargar Alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            //(EColores)Enum.Parse(typeof(EColores), cmbSala.Items[cmbSala.SelectedIndex].ToString())//(EColores)Enum.Parse(typeof(EColores), "Rojo")
            if (int.TryParse(txtDniAlumno.Text,out int dniAux)&& int.TryParse(txtLegajoAlumno.Text, out int legajoAux) && float.TryParse(txtPrecioCuotaAlumno.Text, out float precioAux)&& int.TryParse(txtDniResponsable.Text, out int dniRespAux))
            {
                responsable = new Responsable(txtNombreResponsable.Text, txtApellidoResponsable.Text, dniRespAux, (EParentesco)Enum.Parse(typeof(EParentesco), cmbParentescoResponsable.Text), txtTelefonoResponsable.Text);
                alumno = new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, dniAux, chkFemeninoAlumno.Checked, (EColores)Enum.Parse(typeof(EColores),cmbSala.Text), legajoAux , precioAux, responsable);
                MessageBox.Show("Carga Exitosa");
            }
           
            else
            {
                MessageBox.Show("Error!!Revise los datos");
            }

            txtApellidoAlumno.Text = string.Empty;
            txtApellidoResponsable.Text = string.Empty;
            txtDniAlumno.Text = string.Empty;
            txtDniResponsable.Text = string.Empty;
            txtLegajoAlumno.Text = string.Empty;
            txtNombreAlumno.Text = string.Empty;
            txtNombreResponsable.Text = string.Empty;
            txtPrecioCuotaAlumno.Text = string.Empty;
            txtTelefonoResponsable.Text = string.Empty;
            cmbSala.Text = string.Empty;
        }


        /// <summary>
        /// SelectIndex, lo uso para tomar la sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboMensaje =cmbSala.Items[cmbSala.SelectedIndex].ToString();
            //comboMensaje = cmbSala.Text;
        }
    }
}
