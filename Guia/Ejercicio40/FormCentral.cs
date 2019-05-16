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
    public partial class FormCentral : Form
    {

        private Centralita centralitaForm;

        public FormCentral(Centralita c) //Sería formMenú
        {
            InitializeComponent();
            this.centralitaForm = c;
        }

        private void FormCentral_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerarLlamada_Click(object sender, EventArgs e)
        {
            //Si se presiona btnGenerarLlamada abrir un nuevo formulario como Dialog:
            Form f = new FormLlamador(this.centralitaForm);
            DialogResult result = f.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }
    }



}
