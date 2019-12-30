using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos

        private int legajo;

        #endregion

        #region Constructores

        /// <summary>
        /// Constrcutor público por defecto
        /// </summary>
        public Universitario()
        {

        }

        /// <summary>
        /// Constructor público
        /// </summary>
        /// <param name="legajo">Carga legajo en clase Universitario</param>
        /// <param name="nombre">Carga en la clase base</param>
        /// <param name="apellido">Carga en la clase base</param>
        /// <param name="dni">Carga en la clase base</param>
        /// <param name="nacionalidad">Carga en la clase base</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Métodos

        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Retorna los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Legajo nº: {0}", this.legajo);
            return sb.ToString();
        }

        /// <summary>
        /// Se fija si obj es del tipo Universitario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!ReferenceEquals(obj, null) && obj.GetType() == typeof(Universitario))
            {
                Universitario u = (Universitario)obj;
                if(u.legajo == this.legajo && u.DNI == this.DNI)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales. 
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2);
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion
    }
}
