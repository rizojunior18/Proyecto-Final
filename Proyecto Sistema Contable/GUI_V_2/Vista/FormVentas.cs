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
    public partial class FormVentas : UserControl
    {
        public FormVentas()
        {
            InitializeComponent();
        }
        public void MostrarProductos()
        {
            var productos = CProducto.ShowAllProducts();
            this.dataProductosVentas.DataSource = productos;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}

