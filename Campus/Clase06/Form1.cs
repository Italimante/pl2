using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Desacactivo algunas herramientas
            txtResultado.Enabled = false;
            this.EnableButtons(false);
        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            //Activo botones
            this.EnableButtons(true);
            //Guardo el texto en palabras
            string palabras = rtxtTexto.Text;
            //Envío palabras a la función CantidadPalabras y muestro la cantidad de palabras
            //Corregir: La función cuenta los espacios vacios como palabras también.
            this.lblCantPalabras.Text = this.CantidadPalabras(palabras).ToString();
        }

        #region MÉTODOS 
        //Mal úbicado, creo
        /// <summary>
        /// Funcion para acortar código, desactiva o activa botones
        /// </summary>
        /// <param name="estado"></param>
        private void EnableButtons(bool estado)
        {
            button3primerasO.Enabled = estado;
            button3primerasA.Enabled = estado;
            button100letras.Enabled = estado;
            button20palabras.Enabled = estado;
        }

        /// <summary>
        /// Recibe un string, lo recorta en espacios, y retorna la cantidad de palabras.
        /// PROBLEMA: Cada espacio lo va contar como palabra también.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Cantidad de palabras</returns>
        private int CantidadPalabras(string pTexto)
        {
            char[] eliminarLetras = { ' ', ',', '.', ':', '\t', '\n' };
            string[] palabrasSeparadas = pTexto.Split(eliminarLetras);
            return palabrasSeparadas.Length;
        }

        #endregion

    }
}

