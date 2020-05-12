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
using System.Media;

namespace Jardin
{
    public partial class FrmAltaAula : Form
    {
        List<Alumno> listaAlumnosEnSala;
        private Aula aNaranja;
        private Aula aRoja;
        private Aula aAmarilla;
        private Aula aVerde;
        int indiceCmbProfesor =-1;
        int indexLstv = -1;
        private List<Alumno> alumnosSinAula;
        private List<Docente> docentes;
        SoundPlayer sonidoBtn;

        public FrmAltaAula(List<Alumno> alumnosSinAula,List<Docente> listaDocentesSinAula, Aula aulaNaranja,Aula aulaRoja, Aula aulaAmarilla, Aula aulaVerde, List<Alumno> listaAlumnosEnSala)
        { 
            InitializeComponent();

            this.alumnosSinAula = alumnosSinAula;
            this.aNaranja = aulaNaranja;
            this.aRoja = aulaRoja;
            this.aAmarilla = aulaAmarilla;
            this.aVerde = aulaVerde;
            this.docentes = listaDocentesSinAula;
            this.listaAlumnosEnSala = listaAlumnosEnSala;

        }

        /// <summary>
        /// Form Load. Carga los ComboBox y una lstv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AltaAula_Load(object sender, EventArgs e)
        {
            lblNombreDocente.Text = string.Empty;
            lblColorSalaAula.Text = string.Empty;

            //Cargo los cmb
            foreach (int i in Enum.GetValues(typeof(EColores)))
                cmbColorAltaAula.Items.Add((EColores)i);

            foreach (int i in Enum.GetValues(typeof(ETurno)))
                cmbTurnoAltaAula.Items.Add((ETurno)i);

            foreach (Docente item in docentes)
            {
                cmbProfesor.Items.Add(item.Apellido +" "+ item.Nombre);
            }
          
            //Cargo la lstv, lista de Alumnos en espera.            
            foreach (Alumno item in this.alumnosSinAula)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());

                lstvAlumnosSinAula.Items.Add(lista);
            }

        }

        /// <summary>
        /// Propiedades
        /// </summary>
        public List<Docente> Docentes { get { return this.docentes; } }
        public Aula AulaNaranja { get { return this.aNaranja; } }
        public Aula AulaRoja { get { return this.aRoja; } }
        public Aula AulaAmarilla { get { return this.aAmarilla; } }
        public Aula AulaVerde { get { return aVerde; } }
        public List<Alumno> AlumnosEnSala { get { return this.listaAlumnosEnSala; } }

    /// <summary>
    /// Botón de Alta, Cargo la lista lstv y las aulas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAlta_Click(object sender, EventArgs e)
    {
            sonidoBtn = new SoundPlayer(Application.StartupPath + @"\sonido2.wav");
            sonidoBtn.Play();

            int indice = indexLstv;
            foreach (ListViewItem item in lstvAlumnosSinAula.SelectedItems) 
            {
                item.Remove();
                if (indice >= 0)
                {
                        //Cargo Aulas por color
                        switch (alumnosSinAula[indice].ColorSala) 
                        {
                            case EColores.Naranja:

                            if (aNaranja + alumnosSinAula[indice]) 
                            {
                                listaAlumnosEnSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewNaranja();
                               
                                MessageBox.Show("Se adjudicó Aula con éxito!!!");
                            }
                            else { MessageBox.Show("El Leg ya existe o supera los 30 Alumnos!!"); }

                                break;

                            case EColores.Roja:
                               if (aRoja + alumnosSinAula[indice]) 
                               {
                                listaAlumnosEnSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewRoja();
                                
                                MessageBox.Show("Se adjudicó Aula con éxito!!!");
                               }
                            else { MessageBox.Show("El Leg ya existe o supera los 30 Alumnos!!"); }
       
                            break;

                            case EColores.Amarilla:
                            if (aAmarilla + alumnosSinAula[indice]) 
                            {
                                listaAlumnosEnSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewAmarilla();
                                
                                MessageBox.Show("Se adjudicó Aula con éxito!!!");
                            }
                            else { MessageBox.Show("El Leg ya existe o supera los 30 Alumnos!!"); }
             
                            break;

                            case EColores.Verde:

                            if (aVerde + alumnosSinAula[indice]) 
                            {
                                listaAlumnosEnSala.Add(alumnosSinAula[indice]);                                
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewVerde();

                                MessageBox.Show("Se adjudicó Aula con éxito!!!");
                            }
                            else { MessageBox.Show("El Leg ya existe o supera los 30 Alumnos!!"); }

                            break;
                        }

                }

            }

        }

        /// <summary>
        /// Evento del cmb. Selección de colores y listado de Aulas por color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColorAltaAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColorAltaAula.Text)
            {
                case "Naranja":
                    lstvAlumnosEnSala.BackColor = Color.Orange;
                    lblNombreDocente.Text = string.Empty;
                    lstvAlumnosEnSala.Items.Clear();
                    lblColorSalaAula.Text = "Naranja";
                    if (!(aNaranja is null))
                    {
                        if(!(aNaranja.Docente is null))
                           lblNombreDocente.Text = "Profesor:  "+aNaranja.Docente.Nombre + ", " + aNaranja.Docente.Apellido;
                        CargarListViewNaranja();
                    }
                    break;

                case "Roja":
                    lstvAlumnosEnSala.BackColor = Color.Red;
                    lblNombreDocente.Text = string.Empty;
                    lstvAlumnosEnSala.Items.Clear();
                    lblColorSalaAula.Text = "Roja";
                    if (!(aRoja is null))
                    {
                        if (!(aRoja.Docente is null))
                            lblNombreDocente.Text = "Profesor:  " + aRoja.Docente.Nombre + ", " + aRoja.Docente.Apellido;
                        CargarListViewRoja();
                    }
       
                    break;

                case "Amarilla":
                    lstvAlumnosEnSala.BackColor = Color.Yellow;
                    lblNombreDocente.Text = string.Empty;
                    lstvAlumnosEnSala.Items.Clear();
                    lblColorSalaAula.Text = "Amarilla";
                    if (!(aAmarilla is null))
                    {
                        if (!(aAmarilla.Docente is null))
                            lblNombreDocente.Text = "Profesor:  " + aAmarilla.Docente.Nombre + ", " + aAmarilla.Docente.Apellido;
                        CargarListViewAmarilla();
                    }
                    break;

                case "Verde":
                    lstvAlumnosEnSala.BackColor = Color.Green;
                    lblNombreDocente.Text = string.Empty;
                    lstvAlumnosEnSala.Items.Clear();
                    lblColorSalaAula.Text = "Verde";
                    if (!(aVerde is null))
                    {
                        if (!(aVerde.Docente is null))
                            lblNombreDocente.Text = "Profesor:  " + aVerde.Docente.Nombre+", "+aVerde.Docente.Apellido;
                        CargarListViewVerde();
                    }
                    break;
            }

        }

        private void btnCrearAula_Click(object sender, EventArgs e)
        {
            if (cmbColorAltaAula.Text != "" && cmbTurnoAltaAula.Text != "" && cmbProfesor.Text != "")
            {
                switch (cmbColorAltaAula.Text)
                {
                    case "Naranja":
                        //El índice es de cmbProfesor.SelectedIndex
                        if (indiceCmbProfesor >= 0)
                        {
                            Docente aux = this.docentes[cmbProfesor.SelectedIndex];
                            aNaranja = new Aula((EColores)Enum.Parse(typeof(EColores), cmbColorAltaAula.Text), (ETurno)Enum.Parse(typeof(ETurno), cmbTurnoAltaAula.Text),aux);
                            this.docentes.RemoveAt(indiceCmbProfesor);
                            this.cmbProfesor.Items.Remove(cmbProfesor.Items[cmbProfesor.SelectedIndex]);
                         
                        }

                        break;
                    case "Roja":
                        if (indiceCmbProfesor >= 0)
                        {
                            Docente aux1 = this.docentes[cmbProfesor.SelectedIndex];
                            aRoja = new Aula((EColores)Enum.Parse(typeof(EColores), cmbColorAltaAula.Text), (ETurno)Enum.Parse(typeof(ETurno), cmbTurnoAltaAula.Text), aux1);
                            this.docentes.RemoveAt(indiceCmbProfesor);
                            this.cmbProfesor.Items.Remove(cmbProfesor.Items[cmbProfesor.SelectedIndex]);

                        }
                     
                        break;
                    case "Amarilla":
                        if (indiceCmbProfesor >= 0)
                        {
                            Docente aux2 = this.docentes[cmbProfesor.SelectedIndex];
                            aAmarilla= new Aula((EColores)Enum.Parse(typeof(EColores), cmbColorAltaAula.Text), (ETurno)Enum.Parse(typeof(ETurno), cmbTurnoAltaAula.Text), aux2);
                            this.docentes.RemoveAt(indiceCmbProfesor);
                            this.cmbProfesor.Items.Remove(cmbProfesor.Items[cmbProfesor.SelectedIndex]);

                        }
                     
                        break;

                    case "Verde":
                        if (indiceCmbProfesor >= 0)
                        {
                            Docente aux3 = this.docentes[cmbProfesor.SelectedIndex];
                            aVerde = new Aula((EColores)Enum.Parse(typeof(EColores), cmbColorAltaAula.Text), (ETurno)Enum.Parse(typeof(ETurno), cmbTurnoAltaAula.Text), aux3);
                            this.docentes.RemoveAt(indiceCmbProfesor);
                            this.cmbProfesor.Items.Remove(cmbProfesor.Items[cmbProfesor.SelectedIndex]);
                        }
             
                        break;
                }
            }

            else { MessageBox.Show("No hay Docentes o asegurese de completar los datos!!"); }
            
        }

        private void cmbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceCmbProfesor = cmbProfesor.SelectedIndex;
            string profesor = cmbProfesor.Items[indiceCmbProfesor].ToString();
            //string profesor = cmbProfesor.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método para cargar ListViewAsignados
        /// </summary>
        private void CargarListViewNaranja()
        {
 
            foreach (Alumno item in aNaranja.Alumnos) 
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());

                lstvAlumnosEnSala.Items.Add(lista);
            }
        }

        /// <summary>
        /// Carga Lista Roja
        /// </summary>
        private void CargarListViewRoja()
        {

            foreach (Alumno item in aRoja.Alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());

                lstvAlumnosEnSala.Items.Add(lista);
            }
        }

        /// <summary>
        /// Carga lista Amarilla
        /// </summary>
        private void CargarListViewAmarilla()
        {
 
            foreach (Alumno item in aAmarilla.Alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());

                lstvAlumnosEnSala.Items.Add(lista);
            }
        }

        /// <summary>
        /// Carga lista Verde
        /// </summary>
        private void CargarListViewVerde()
        {

            foreach (Alumno item in aVerde.Alumnos) 
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());

                lstvAlumnosEnSala.Items.Add(lista);
            }
        }

        /// <summary>
        /// Evento para tomar el indice de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstvAlumnosSinAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int item in this.lstvAlumnosSinAula.SelectedIndices)
            {
                indexLstv = item;
            }
        }

    }
}
