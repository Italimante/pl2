using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo:IMostrar<List<Paquete>>
    {
        #region Atributos
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad publica de lectura y escritura, devuelve una lista de paquetes o asigna una lista de paquetes.
        /// </summary>
        public List<Paquete> Paquete
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor publico por defecto que inicializa las lista de paquetes e hilos
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquete = new List<Paquete>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Busca en la lista de mockPaquetes los hilos que hayan y los aborta (el único aborto legal, seguro y gratuito)
        /// </summary>
        public void FinEntregas()
        { 
            foreach(Thread h in this.mockPaquetes)
            {
                h.Abort();
            }
        }

        /// <summary>
        /// MostrarDatos utilizará string.Format con el siguiente formato
        /// "{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()
        /// para retornar los datos de todos los paquetes de su lista.
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> paquetes = (List<Paquete>)((Correo)elementos).Paquete;

            StringBuilder sb = new StringBuilder();

            foreach(Paquete p in paquetes)
            {
                sb.AppendLine( string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()) );
            }

            return sb.ToString();
        }


        /// <summary>
        ///  2. En el operador +:
        /// a.Controlar si el paquete ya está en la lista. En el caso de que esté, 
        /// se lanzará la excepción TrackingIdRepetidoException.
        /// b.De no estar repetido, agregar el paquete a la lista de paquetes.
        /// c.Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes. 
        /// d.Ejecutar el hilo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator+(Correo c, Paquete p)
        {

            foreach(Paquete pac in c.paquetes)
            {
                if(pac == p)
                {
                    throw new TrackingIdRepetidoException(string.Format("El paquete {0}, ya se encuentra en la lista.", p.TrackingID));
                }
            }

            //Como no esta repetido agrego el paquete a la lista:
            c.paquetes.Add(p);
            //Crear un hilo para el método MockCicloDeVida del paquete y agregar dicho hilo a mockpaquetes
            ThreadStart delegado = new ThreadStart(p.MockCicloDeVida); //Creo el delegado
            Thread hilo = new Thread(delegado); //Creo la instancia del hilo
            c.mockPaquetes.Add(hilo); // y agregar dicho hilo a mockpaquetes
            hilo.Start(); //Ejecuto el hilo

            return c;
        }

        #endregion


    }
}
