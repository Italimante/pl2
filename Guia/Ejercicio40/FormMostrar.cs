using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio40
{
    public partial class FormMostrar : Form
    {

        private Centralita centralita;

        public FormMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
