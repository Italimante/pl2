using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
1. Implementar la interfaz IMostrar, siendo su tipo genérico Paquete.
2. MostrarDatos utilizará string.Format con el siguiente formato para compilar la información del paquete.
    "{0} para {1}", p.trackingID, p.direccionEntrega
3. La sobrecarga del método ToString retornará la información del paquete.
4. Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo.
5. MockCicloDeVida hará que el paquete cambie de estado de la siguiente forma:
    a. Colocar una demora de 4 segundos.
    b. Pasar al siguiente estado.
    c. Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra.
    d. Repetir las acciones desde el punto A hasta que el estado sea Entregado.
    e. Finalmente guardar los datos del paquete en la base de datos
*/

namespace Entidades
{
    public class Paquete:IMostrar<Paquete>
    {
        #region Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        public enum EEstado { Ingresado,EnViaje,Entregado};
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad publica de lectura y escritura. Devuelve y/o asigna la dirección de entrega.
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura. Devuelve y/o asigna el estado del paquete.
        /// </summary>
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura. Devuelve y/o asigna el ID del rastreo del paquete.
        /// </summary>
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Único constructor, público, asigna la dirección de entrega, el trackingID recibidos por parametros y por defecto el estado en Ingresado.
        /// </summary>
        /// <param name="direccionEntrega"></param>
        /// <param name="trackingID"></param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.TrackingID = trackingID;
            this.DireccionEntrega = direccionEntrega;
            this.Estado = EEstado.Ingresado;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// 5. MockCicloDeVida hará que el paquete cambie de estado de la siguiente forma:
        ///     a. Colocar una demora de 4 segundos.
        ///     b. Pasar al siguiente estado.
        ///     c. Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra.
        ///     d. Repetir las acciones desde el punto A hasta que el estado sea Entregado.
        ///     e. Finalmente guardar los datos del paquete en la base de datos
        /// </summary>
        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(4000);
                this.Estado += 1;
                this.InformaEstado(this, new EventArgs());
            } while (this.Estado != EEstado.Entregado);

            PaqueteDAO.Insertar(this);
        }

        /// <summary>
        /// MostrarDatos utilizará string.Format con el siguiente formato para compilar la información del paquete.
        /// "{0} para {1}", p.trackingID, p.direccionEntrega
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format( "{0} para {1}",p.trackingID,p.direccionEntrega );
        }

        /// <summary>
        /// Retorna la información del paquete
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /*
            //ESTO NO PORQUE EL ESTADO SE INFORMA MEDIANTE OTROS MEDIOS
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Dirección: {0}",this.DireccionEntrega);
            sb.AppendFormat("\nTracking ID: {0}", this.TrackingID);
            sb.AppendFormat("\nEstado: {0}\n", this.Estado);
            return sb.ToString();*/
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return p1.TrackingID == p2.TrackingID;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Eventos

        public event DelegadoEstado InformaEstado;

        public delegate void DelegadoEstado(object sender, EventArgs e);

        #endregion

    }
}
