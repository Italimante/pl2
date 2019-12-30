using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos

        public enum ENacionalidad { Argentino, Extranjero };
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor público
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        //Siento que entre las dos propiedades de abajo, podrían llamarse entre si convirtiendo el DNI de string a INT, pero no pude.

        /// <summary>
        /// Constrcutor público
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni">DNI en entero</param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,dni.ToString(),nacionalidad)
        {
            
        }

        /// <summary>
        /// Constructor público
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni">DNI en string</param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre, apellido ,nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Obtiene o agrega la nacionalidad de la persona
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// Obtiene o agrega el DNI de la persona
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set
            {
                this.StringToDNI = value.ToString();
            }
        }

        /// <summary>
        /// Agrega el DNI de la persona en string
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Mostrata los datos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}", this.nombre);
            sb.AppendFormat("\nApellido: {0}", this.apellido);
            sb.AppendFormat("\nNacionalidad: {0}", this.nacionalidad);
            sb.AppendFormat("\nDNI: {0}", this.dni);
            return sb.ToString();
        }


        /// <summary>
        /// Valida el rango del DNI, y si corresponde a la nacionalidad indicada, lanza NacionalidadInvalidaException
        /// Valida si el DNI presenta un error de formato, lanza DniInvalidoException.
        /// Llama a su sobrecarga que recibe un string como parametro
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }

        /// <summary>
        /// Valida el rango del DNI, y si corresponde a la nacionalidad indicada, lanza NacionalidadInvalidaException
        /// Valida si el DNI presenta un error de formato, lanza DniInvalidoException.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if (int.TryParse(dato, out dni) && dato.Length == 8)
            {

                if (dni >= 1 && dni <= 89999999)
                {
                    if (ENacionalidad.Argentino == nacionalidad) { //Se que tiene que ir en el if de arriba
                        return dni;
                    }
                }
                else if (dni >= 90000000 && dni <= 99999999)
                {
                    if (ENacionalidad.Extranjero == nacionalidad) //Se que tiene que ir en el if de arriba
                    {
                        return dni;
                    }
                }

                throw new NacionalidadInvalidaException("Error de nacionalidad");

            }

            throw new DniInvalidoException("DNI invalido");

        }

        /// <summary>
        /// Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se
        /// cargará.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (new Regex(@"^[a-zA-Z]+$").IsMatch(dato))
            {
                return dato;
            }

            return string.Empty;
        }

        #endregion

    }
}
