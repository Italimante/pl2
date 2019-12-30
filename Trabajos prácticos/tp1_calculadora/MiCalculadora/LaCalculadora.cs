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

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {

        public LaCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOperador.SelectedItem = "+";
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        public void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "0";
        }

        private static double Operar(string numero1, string numero2, string operar)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);
           return Calculadora.Operar(n1, n2, operar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            bool sucess = int.TryParse(txtNumero2.Text.ToString(), out int aux);
            if (sucess) //Si lo que hay es un numero:
            {
                if (int.Parse(txtNumero2.Text) == 0 && cmbOperador.SelectedItem.ToString() == "/") //Me fijo que no este dividiendo entre 0
                {
                    lblResultado.Text = "No se puede dividir entre cero";
                }
                else
                {
                    double resultado = LaCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString());
                    lblResultado.Text = resultado.ToString();
                    this.btnConvertirABinario.Enabled = true;
                    this.btnConvertirADecimal.Enabled = true;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text != "0")
            {
                lblResultado.Text = Numero.DecimalBinario( lblResultado.Text.ToString() );
                //Para no volver a operar lo mismo:
                this.btnConvertirABinario.Enabled = false;
                this.btnConvertirADecimal.Enabled = true;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text.ToString());
            //Para no volver a operar lo mismo:
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = true;
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
