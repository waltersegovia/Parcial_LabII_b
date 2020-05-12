using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Docente:
// Redefine CalcularSalario multiplicando el valorHora por la cantidad de horas diarias por 20 días hábiles
// Y un constructor publico que carga todos sus atributos

namespace Entidades
{
    public class Docente:Personal 
    {
        private double valorHora;

        public int HorasMensuales
        {
            get
            {
                return (int)(CalcularSalario() / valorHora);
            }
        }

        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }

        /// <summary>
        /// Redefine CalcularSalario multiplicando el valorHora por la cantidad de horas diarias por 20 días hábiles
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            TimeSpan horasDiarias = new TimeSpan();
            horasDiarias = (base.HoraSalida - base.HoraEntrada);
            double horas = horasDiarias.TotalHours;
            return (valorHora * horas * 20);
        }

        /// <summary>
        /// Constructor publico que carga todos sus atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="valorHora"></param>
        public Docente(string nombre,string apellido,int dni,bool femenino,DateTime horaEntrada,DateTime horaSalida,double valorHora)
            :base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.valorHora = valorHora;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Docente:{0} {1} {2} {3} {4}", this.Nombre, this.Apellido, this.Dni, this.Femenino, this.HoraEntrada,this.HoraSalida);
            return sb.ToString();
        }
    }
}
