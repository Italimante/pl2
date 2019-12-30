using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        public enum EClases { Laboratorio, Programacion, Legislacion, SPD }
        #endregion

        #region Propiedades
        /// <summary>
        /// Carga o retorna una lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        /// <summary>
        /// Carga o retorna una lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return this.profesores;  }
            set { this.profesores = value; }
        }
        /// <summary>
        /// Carga o retorna una lista de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    return this.Jornadas[i];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor publico que inicializa las listas de la clase
        /// </summary>
        public Universidad()
        {
            this.Jornadas = new List<Jornada>();
            this.Instructores = new List<Profesor>();
            this.Alumnos = new List<Alumno>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Serializa una universidad en xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            if(!new Xml<Universidad>().Guardar("Universidad.xml", uni))
            {
                throw new ArchivosException("La universidad no pudo ser guardada");
            }
            return true;
        }

        /// <summary>
        /// Deserializa un xml de universidad en universidad
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad auxUni;

            if (!new Xml<Universidad>().Leer("Universidad.xml", out auxUni))
            {
                throw new ArchivosException("La universidad no pudo ser leida");
            }

            return auxUni;
        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada item in uni.Jornadas)
            {
                
                sb.AppendLine("Jornada:");
                sb.AppendLine(item.ToString());
                sb.AppendLine("< -------------------------------------------- >");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            return g.Alumnos.Contains(a);
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            return g.Instructores.Contains(i);
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
        ///Sino, lanzará la Excepción SinProfesorException.El distinto retornará el primer Profesor que no
        ///pueda dar la clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach(Profesor p in g.Instructores)
            {
                if (p == clase)
                {
                    return p;
                }
            }

            throw new SinProfesorException("No hay profesor disponible\n");
        }
        /// <summary>
        /// El primer profesor que no pueda dar la clase
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor p in g.Instructores)
            {
                if (p != clase)
                {
                    return p;
                }
            }

            throw new SinProfesorException("Inconveniente con el primer profesor que no pueda dar la clase\n");
        }

        /// <summary>
        /// Agrega una jornada, con los alumnos y el profesor de la clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j = new Jornada(clase, g==clase);
            foreach(Alumno a in g.Alumnos)
            {
                if(a == clase)
                {
                    j.Alumnos.Add(a);
                }
            }
            g.Jornadas.Add(j);
            return g;
        }

        /// <summary>
        /// Agrega un alumno a la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }
            else
            {
                throw new AlumnoRepetidoException("El alumno no pudo ser agregado\n");
            }
        }

        /// <summary>
        /// Agrega un profesor a la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
                return u;
            }
            else
            {
                throw new AlumnoRepetidoException("El profesor no pudo ser agregado\n");
            }
        }


        #endregion


    }
}
