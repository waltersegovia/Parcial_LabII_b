using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //Administrativo: 

 //Cuenta con un atributo estático SalarioBase.
 //Redefine CalcularSalario multiplicando el salario base por el porcentaje de su cargo dividido 100
 //Tambien tiene un constructor estatico que setea el salarioBase = 30000 y uno de instancia
 //por el cual se cargan todos los atributos que tiene un administrativo

namespace Entidades
{
    public class Administrativo:Personal
    {
        private ECargo cargo;
        public static double SalarioBase;

        public ECargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        /// <summary>
        /// Constructor estatico que setea el salarioBase = 30000 
        /// </summary>
        static Administrativo()
        {
            SalarioBase = 30000;
        }

        /// <summary>
        /// Redefine CalcularSalario multiplicando el salario base por el porcentaje de su cargo dividido 100
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            int puesto = (int)cargo;
            return SalarioBase * puesto / 100;
        }

        /// <summary>
        /// Se cargan todos los atributos que tiene un administrativo
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="cargo"></param>
        public Administrativo(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo)
            :base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.cargo = cargo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Administrativo:{0} {1} {2} {3} {4}", this.Nombre, this.Apellido, this.Dni, this.Femenino, this.cargo);
            return sb.ToString();
        }
    }
}
