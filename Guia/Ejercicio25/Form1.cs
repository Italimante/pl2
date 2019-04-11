using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio22;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = "Ejercicio25";

            //Desactivo los botones para que no se puedan usar antes de introducir un número
            btnBinToDec.Enabled = false;
            btnDecToBin.Enabled = false;

            //Solo lectura a los textBox de resultados
            txtResultadoDec.ReadOnly = true;
            txtResultadoBin.ReadOnly = true;
        }


        #region Binario a decimal
        private void txtBinario_TextChanged(object sender, EventArgs e)
        {
            btnBinToDec.Enabled = true;
        }

        private void txtBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("Solo se permiten números, no letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if ( e.KeyChar != (char)Keys.D1 && e.KeyChar != (char)Keys.D0 && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números 1 (uno) y 0 (cero).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            string binario = txtBinario.Text;
            txtResultadoDec.Text = Conversor.BinarioDecimal(binario).ToString();
        }

        private void txtResultadoDec_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Decimal a binario
        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            btnDecToBin.Enabled = true;
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDecimal.Text);
            txtResultadoBin.Text = Conversor.DecimalBinario(num);
        }

        private void txtResultadoBin_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
