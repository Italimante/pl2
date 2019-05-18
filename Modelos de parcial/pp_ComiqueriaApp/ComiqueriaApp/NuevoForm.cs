using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class NuevoForm : Form
    {
        private Producto productoNuevo;

        public NuevoForm()
        {
            InitializeComponent();
        }

        public Producto DevolverProducto
        {
            get
            {
                return this.productoNuevo;
            }
        }

        private void NuevoForm_Load(object sender, EventArgs e)
        {
            this.comboBoxTipoProducto.Items.Add("Figura");
            this.comboBoxTipoProducto.Items.Add("Comic");
            this.comboBoxTipoProducto.SelectedItem = "Comic";

            this.comboBoxTipoDeComic.DataSource = Enum.GetValues(typeof(Comic.TipoComic));

            this.groupBoxComic.Enabled = false;
            this.groupBoxFigura.Enabled = false;
        }

        private void comboBoxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxTipoProducto.SelectedItem == "Comic")
            {
                this.groupBoxComic.Enabled = true;
                this.groupBoxFigura.Enabled = false;
            }
            else
            {
                this.groupBoxComic.Enabled = false;
                this.groupBoxFigura.Enabled = true;
            }
            
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(this.comboBoxTipoProducto.SelectedItem == "Comic")
            {
                Producto producto2 = new Figura("LALALALALALALALAL", 2, 650.00, 29.00);
                this.productoNuevo = producto2;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //Llamo a constructor de figura
            }
        }
    }
}
