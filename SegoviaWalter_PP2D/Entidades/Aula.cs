using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aula: 
//Cada aula tiene un docente y no más de 30 alumnos.

namespace Entidades
{
    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno turno;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }

        public ETurno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }


        public Aula()
        {
            alumnos = new List<Alumno>();
        }

        public Aula(EColores colorSala,ETurno turno,Docente docente):this()
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;   
        }

        /// <summary>
        /// Agrega un alumno si no está en la lista y si no supera los 30 en el aula.
        /// </summary>
        /// <param name="aula"></param>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public static bool operator +(Aula aula,Alumno alumno)
        {
            foreach (Alumno item in aula.alumnos)
            {
                if (item == alumno)
                    return false;
            }

            if (aula.alumnos.Count < 30)
            {
                aula.alumnos.Add(alumno);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Aula:{0} {1} {2}", this.colorSala, this.docente, this.turno);
            return sb.ToString();
        }
    }
}
