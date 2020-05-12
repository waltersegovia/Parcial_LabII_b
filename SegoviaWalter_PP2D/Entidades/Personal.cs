using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public double Salario
        {
            get
            {
                return CalcularSalario();//Revisar
            } 
        }

        protected abstract double CalcularSalario();

        protected Personal(string nombre,string apellido,int dni,bool femenino, DateTime horaEntrada,DateTime horaSalida):base(nombre,apellido,dni,femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

    }
}
