using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

/*
 Atributos Profesor, Clase y Alumnos que toman dicha clase.
 Se inicializará la lista de alumnos en el constructor por defecto.
 Una Jornada será igual a un Alumno si el mismo participa de la clase.
 Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente
cargados.
 ToString mostrará todos los datos de la Jornada.
 Guardar de clase guardará los datos de la Jornada en un archivo de texto.
 Leer de clase retornará los datos de la Jornada como texto.
*/

namespace EntidadesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades

        /// <summary>
        /// Carga y devuelve una lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Carga y devuelve las clases
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Carga y devuelve un profesor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Constrcutores

        /// <summary>
        /// Se inicializará la lista de alumnos en el constructor por defecto.
        /// </summary>
        public Jornada() {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor publico, inicializaz las clases y el instructor
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Guardar de clase guardará los datos de la Jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            if (!new Texto().Guardar("Jornada.txt", jornada.ToString()))
            {
                throw new ArchivosException("Error al guardar jornada");
            }

            return true;
        }

        /// <summary>
        /// Leer de clase retornará los datos de la Jornada como texto.
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string datos;

            if (!new Texto().Leer("Jornada.txt", out datos))
            {
                throw new ArchivosException("Error al leer el archivo de jornada");
            }

            return datos;
        }

        /// <summary>
        /// ToString mostrará todos los datos de la Jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Clase de {0} tomada por {1}\n", this.Clase, this.Instructor.ToString());
            sb.AppendLine("ALUMNOS:");

            if (this.Alumnos.Count > 0) { 

                foreach (Alumno a in this.Alumnos)
                {
                    sb.AppendLine(a.ToString());
                }

            }
            else
            {
                sb.AppendLine("No hay alumnos en esta jornada");
            }

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return j.alumnos.Contains(a);
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente
        /// cargados.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        #endregion

    }
}
