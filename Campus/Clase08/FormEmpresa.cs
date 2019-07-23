using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase08
{
    public partial class FormEmpresa : Form
    {

        public Empresa empresa;

        public FormEmpresa()
        {
            InitializeComponent();
            this.Text = "Empresa";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.empresa = new Empresa(
                this.textBoxRazonSocial.Text, 
                this.textBoxDireccion.Text, 
                float.Parse(this.maskedTextBoxGanancias.Text)
                );

            this.DialogResult = DialogResult.OK;

            this.Close();

        }
    }
}
