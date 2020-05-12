using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Alumno: 
// Dos Alumnos son iguales si comparten legajo y al castearlo a Responsable,
// devuelve a su Responsable Y un constructor publico que carga todos sus atributos.

namespace Entidades
{
    public class Alumno:Persona
    {
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;

        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }
        /// <summary>
        /// Constructor de Alumno
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="colorSala"></param>
        /// <param name="legajo"></param>
        /// <param name="precioCuota"></param>
        /// <param name="responsable"></param>
        public Alumno(string nombre,string apellido,int dni,bool femenino,EColores colorSala,int legajo,float precioCuota,Responsable responsable)
            :base(nombre,apellido,dni,femenino)
        {
            this.responsable = responsable;
            this.colorSala = colorSala;
            this.legajo = legajo;
            this.precioCuota = precioCuota;
        }

        /// <summary>
        /// Al castearlo a Responsable, devuelve a su Responsable.
        /// </summary>
        /// <param name="a"></param>
        public static implicit operator Responsable(Alumno a)
        {
            return a.responsable;           
        }

        /// <summary>
        /// Dos Alumnos son iguales si comparten legajo.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1,Alumno a2)
        {
            return (a1.legajo==a2.legajo);
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1==a2);
        }

        /// <summary>
        /// ToString() de Alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Alumno:{0} {1} {2} {3} {4}", this.Nombre, this.Apellido, this.Dni, this.Femenino, this.legajo);
            return sb.ToString();
        }
    }
}
