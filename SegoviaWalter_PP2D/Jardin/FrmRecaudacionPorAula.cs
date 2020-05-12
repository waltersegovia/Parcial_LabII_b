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
    public partial class FrmRecaudacionPorAula : Form
    {
        List<Alumno> listaAlumnosEnSala;

        public FrmRecaudacionPorAula(List<Alumno> listaAlumnosEnSala)
        {
            InitializeComponent();

            this.listaAlumnosEnSala = listaAlumnosEnSala;
        }

        private void FrmRecaudacionPorAula_Load(object sender, EventArgs e)
        {
            lblRecaudacionNaranja.Text = string.Empty;
            lblRecaudacionRoja.Text = string.Empty;
            lblRecaudacionAmarilla.Text = string.Empty;
            lblRecaudacionVerde.Text = string.Empty;
            double recNaranja = 0;
            double recRoja = 0;
            double recAmarilla = 0;
            double recVerde = 0;

            foreach (Alumno item in listaAlumnosEnSala )
            {
                switch (item.ColorSala)
                {
                    case EColores.Naranja:
                        recNaranja += item.PrecioCuota;
                        break;
                    case EColores.Roja:
                        recRoja += item.PrecioCuota;
                        break;
                    case EColores.Amarilla:
                        recAmarilla+= item.PrecioCuota;
                        break;
                    case EColores.Verde:
                        recVerde += item.PrecioCuota;
                        break;          
                }

            }

            lblRecaudacionNaranja.Text = "Sala Naranja: $" + recNaranja.ToString();
            lblRecaudacionRoja.Text = "Sala Roja: $" + recRoja.ToString();
            lblRecaudacionAmarilla.Text = "Sala Amarilla: $" + recAmarilla.ToString();
            lblRecaudacionVerde.Text = "Sala Verde: $" + recVerde.ToString();
        }
    }
}
