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
            HabilitarTextbox(false);
            this.btnGuardar.Enabled = false;
            this.btnActualizar.Enabled = false;
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

        public void LimpiarTextbox()
        {
            this.txtNombreProducto.Text = String.Empty;
            this.txtPrecio.Text = String.Empty;
            this.txtCantidadDisponible.Text = String.Empty;
            this.txtMarca.Text = String.Empty;
            this.txtDescripcion.Text = String.Empty;
            this.txtCategoria.Text = String.Empty;



            // this.txtEstado.Text = String.Empty;
            this.dataGridViewProductos.ClearSelection();
        }
        public void HabilitarTextbox(bool dato)
        {
            this.txtNombreProducto.Enabled = dato;
            this.txtPrecio.Enabled = dato;
            this.txtCantidadDisponible.Enabled = dato;
            this.txtMarca.Enabled = dato;
            this.txtDescripcion.Enabled = dato;
            this.txtCategoria.Enabled = dato;


            // this.txtEstado.Text = String.Empty;

        }
        public void ControlBotones(string dato)
        {
            if (dato == "Nuevo")
            {

                this.HabilitarTextbox(true);
                this.LimpiarTextbox();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnActualizar.Enabled = false;


            }
            else
            if (dato == "Guardar")
            {

                this.HabilitarTextbox(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnActualizar.Enabled = true;


            }

            else
            if (dato == "Actualizar")
            {
                this.LimpiarTextbox();
                this.HabilitarTextbox(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnActualizar.Enabled = true;


            }
        }
    }
}
