using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

/*
 Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
 Sobrescribir el método MostrarDatos con todos los datos del profesor.
 ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
 ToString hará públicos los datos del Profesor.
 Se inicializará a Random sólo en un constructor.
 En el constructor de instancia se inicializará ClasesDelDia 
    y se asignarán dos clases al azar al Profesor mediante el método randomClases. 
    Las dos clases pueden o no ser la misma.
 Un Profesor será igual a un EClase si da esa clase.
*/
namespace EntidadesInstanciables
{
    public class Profesor:Universitario
    {
        #region Atributos
        private static Random random;
        private Queue<Universidad.EClases> clasesDelDia;
        #endregion

        #region Constructores

        /// <summary>
        /// Inicia 
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();    
        }

        public Profesor() { }

        /// <summary>
        /// Constructor público, inicia la cola de clases del profesor, y llama a la función randomClases
        /// que le asigna dos clases al azar al profesor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agrega dos clases al final de la cola de clases del día del profesor.
        /// El "_" guion bajo lo dejé porque está en el diagrama así
        /// Tiene un sleep de un cuarto de segundo por si las flyes
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
            System.Threading.Thread.Sleep(250);
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// Retorna un string con las clases del profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Clases del día:");

            if (!ReferenceEquals(this.clasesDelDia, null))
            {
                foreach(Universidad.EClases clase in this.clasesDelDia)
                {
                    sb.AppendFormat("{0}\n", clase);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// ToString hará públicos los datos del Profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase) {
            return !(i == clase);
        }

        #endregion

    }
}
