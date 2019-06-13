using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{

    delegate void CambiarHoraDelegado(DateTime t);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ThreadStart delegado = new ThreadStart(AsignarHora);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        public void AsignarHora()
        {
            DateTime t = DateTime.Now;
            this.labelHora.Text = t.ToString();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                this.CambiarHora(DateTime.Now);
            }

            MessageBox.Show("Terminó de medir la hora");

        }

        private void CambiarHora(DateTime t)
        {
            if (this.InvokeRequired)
            {
                CambiarHoraDelegado delegado = new CambiarHoraDelegado(CambiarHora);
                object[] parametros = { t };
                this.Invoke(delegado, t);
            }
            else
            {
                this.labelHora.Text = t.ToString();
            }
        }
    }
}
