using GUI_V_2.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Vista
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void MostrarProductos()
        {
            var productos = CProducto.ShowAllProducts();
            this.dataGridViewProductos.DataSource = productos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = this.txtNombreProducto.Text;
            string descripcion = this.txtDescripcion.Text;
            string categoria = this.txtCategoria.Text;
            string marca = this.txtMarca.Text;
            int precio = Convert.ToInt32(this.txtPrecio.Text);
            int cantidadDisponible = Convert.ToInt32(this.txtCantidadDisponible.Text);

            CProducto.SaveProduct(nombreProducto, descripcion, categoria, marca, precio, cantidadDisponible);
            MessageBox.Show("Producto agregado correctamente ");

            MostrarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
