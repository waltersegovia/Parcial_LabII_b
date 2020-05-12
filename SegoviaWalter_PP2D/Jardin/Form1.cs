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

//o Alta de docente
//o Alta no docente
//o Alta alumno
//o Alta aula:
// Cada pantalla cambiará de color en base al color de Aula
// Deberá listar los docentes que aún no tengan un aula asignada para ese turno del aula.
//  Es decir, listará los docentes que tengan disponibilidad para tomar esa aula.
// Deberá listar también los alumnos que puedan pertenecer a esa aula en base al atributo correspondiente y que no tengan Sala asignada aún.
// Se deberá poder asignar alumnos a esa aula. Al guardar, se agregará a la lista de Aulas de la pantalla principal.

namespace Jardin
{
    public partial class Form1 : Form
    {
        private List<Alumno> listaAlumnosEnSala;
        private List<Alumno> listaAlumnosSinAula;
        private List<Docente> listaDocentesSinAula; 
        private List<Administrativo> listaNoDocente;
        private Aula aula;
        private Aula aulaNaranja;
        private Aula aulaRoja;
        private Aula aulaAmarilla;
        private Aula aulaVerde;



        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            listaAlumnosSinAula = new List<Alumno>();
            listaAlumnosEnSala = new List<Alumno>();
            listaDocentesSinAula = new List<Docente>();
            listaNoDocente = new List<Administrativo>();

            aula = new Aula();          
            aulaNaranja = new Aula();
            aulaRoja = new Aula();
            aulaAmarilla = new Aula();
            aulaVerde = new Aula();
        }

        /// <summary>
        /// Alta de Aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaAlulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAula frmAltaAula = new FrmAltaAula(listaAlumnosSinAula, listaDocentesSinAula, aulaNaranja, aulaRoja, aulaAmarilla, aulaVerde, listaAlumnosEnSala);
            if (frmAltaAula.ShowDialog() == DialogResult.OK)
            {
                aulaNaranja = frmAltaAula.AulaNaranja;
                aulaRoja = frmAltaAula.AulaRoja;
                aulaAmarilla = frmAltaAula.AulaAmarilla;
                aulaVerde = frmAltaAula.AulaVerde;
                listaDocentesSinAula = frmAltaAula.Docentes;
                listaAlumnosEnSala = frmAltaAula.AlumnosEnSala;
            }


            //****** Opcional Para MdiParent ******//

                //frmAltaAula.MdiParent = this;
                //frmAltaAula.Show();

                //aulaNaranja = frmAltaAula.AulaNaranja;
                //aulaRoja = frmAltaAula.AulaRoja;
                //aulaAmarilla = frmAltaAula.AulaAmarilla;
                //aulaVerde = frmAltaAula.AulaVerde;
                //listaDocentesSinAula = frmAltaAula.Docentes;
                //listaAlumnosEnSala = frmAltaAula.AlumnosEnSala;
            
        }

        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Alta Docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaDocente frmAltaDocente = new FrmAltaDocente();
            if (frmAltaDocente.ShowDialog() == DialogResult.OK)
            {
                listaDocentesSinAula.Add(frmAltaDocente.Docente);
            }
        }

        /// <summary>
        /// Alta No Docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaNoDocente frmAltaNoDocente = new FrmAltaNoDocente();

            if (frmAltaNoDocente.ShowDialog()==DialogResult.OK)
            {
                listaNoDocente.Add(frmAltaNoDocente.NoDocente);
            }
           
        }

        /// <summary>
        /// Alta de Alumno. Crea un alumno en frmAltaAlumno y guarda en la lista de Frm1 listaAlumnosSinAula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno frmAltaAlumno = new FrmAltaAlumno();
            if (frmAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                //Uso la sobrecarga + de Aula
                if (aula + frmAltaAlumno.Alumno)
                {
                    this.listaAlumnosSinAula = aula.Alumnos;
                    MessageBox.Show("Se Cargó en lista de espera!!!");
                }

                else
                {
                    MessageBox.Show("El legajo ya existe!!!");
                }

            }
        }

        private void informacionDePadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformacionDePadres frmInformacionDePadres = new FrmInformacionDePadres(listaAlumnosEnSala);
            frmInformacionDePadres.ShowDialog();

        }

        private void recaudaciónNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalarioDocente frmSalarioDocente = new FrmSalarioDocente(listaDocentesSinAula);
            frmSalarioDocente.ShowDialog();

        }

        private void recaudaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalarioNoDocente frmSalarioNoDocente = new FrmSalarioNoDocente(listaNoDocente);
            frmSalarioNoDocente.ShowDialog();
        }

        private void recaudaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmRecaudacionPorAula frmRecaudacionPorAula = new FrmRecaudacionPorAula(listaAlumnosEnSala);
            frmRecaudacionPorAula.ShowDialog();
        }

        private void recaudaciónTotalDelJardínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTotalJardin frmTotalJardin = new FrmTotalJardin(listaAlumnosEnSala);
            frmTotalJardin.ShowDialog(); 
        }

        /// <summary>
        /// Carga Instancias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaInfo cargar = new CargaInfo();

            cargar.Carga();

            listaAlumnosSinAula = cargar.listaAlumnos;
            listaDocentesSinAula = cargar.Docentes;
            listaNoDocente = cargar.NoDocentes;
            MessageBox.Show("Carga exitosa!!");
        }
    }
}
