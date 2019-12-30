using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FrmPpal : Form
    {
        private Correo correo;

        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        #region Métodos


        /// <summary>
        /// Actualiza los estados del paquete en las listas
        /// </summary>
        private void ActualizarEstados()
        {

            this.lstEstadoEntregado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoIngresado.Items.Clear();

            #region New con Switch

            foreach (Paquete p in this.correo.Paquete)
            {
                switch (p.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(p);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(p);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(p);
                        break;
                    default:
                        break;
                }
            }

            #endregion

            #region Old con if
            //foreach (Paquete p in this.correo.Paquete)
            //{
            //    if (p.Estado == Paquete.EEstado.Ingresado)
            //    {
            //        this.lstEstadoIngresado.Items.Add(p);
            //        break;
            //    }
            //    else if (p.Estado == Paquete.EEstado.EnViaje)
            //    {
            //        this.lstEstadoEnViaje.Items.Add(p);
            //        break;
            //    }
            //    else
            //    {
            //        this.lstEstadoEntregado.Items.Add(p);
            //        break;
            //    }
            //}
            #endregion
        }

        /// <summary>
        /// El método MostrarInformacion<T> evaluará que el atributo elemento no sea nulo y:
        ///a.Mostrará los datos de elemento en el rtbMostrar.
        ///b.Utilizará el método de extensión para guardar los datos en un archivo llamado salida.txt.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!Equals(elemento,null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                (elemento.MostrarDatos(elemento)).Guardar("salida.txt"); //?? acá no entendí nada, me la pasaron a esta línea
            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        #endregion

        /// <summary>
        /// El evento click del botón btnAgregar realizará las siguientes acciones en el siguiente orden:
        ///a.Creará un nuevo paquete y asociará al evento InformaEstado el método paq_InformaEstado.
        ///b.Agregará el paquete al correo, controlando las excepciones que puedan derivar de dicha
        ///acción.
        ///c.Llamará al método ActualizarEstados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text); //Creará un nuevo paquete
            p.InformaEstado += this.paq_InformaEstado; //Asociará el evento
            try
            {
                this.correo += p; //Agregará el paquete al correo
            }
            catch (TrackingIdRepetidoException ex) //Controlando las excepciones que pueden derivar de dicha acción
            {
                MessageBox.Show( ex.Message, "Paquete ya existente", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }

            this.ActualizarEstados(); //Llamará al método ActualizarEstados
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// Al cerrarse el formulario, se deberá llamar al método FinEntregas a fin de cerrar todos los hilos
        /// abiertos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

    }

}
