using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Responsable:
// Tiene un constructor de instancia publico que pide todos sus atributos y los setea.

namespace Entidades
{
    public class Responsable : Persona
    {
        private EParentesco parentesco;
        private string telefono;

        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        } 

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        /// <summary>
        /// Constructor de Responsable
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="parentesco"></param>
        /// <param name="telefono"></param>
        public Responsable(string nombre,string apellido,int dni,EParentesco parentesco,string telefono):base(nombre,apellido,dni)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Responsable:  {0} - {1}, {2} DNI:{3} Fem: {4} Tel: {5}", this.parentesco, this.Nombre, this.Apellido, this.Dni, this.Femenino,this.telefono);
            return sb.ToString();
        }
    }
}
