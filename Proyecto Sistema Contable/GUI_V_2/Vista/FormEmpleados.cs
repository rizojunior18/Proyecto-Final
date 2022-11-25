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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string primerNombre = this.txtPrimerNombre.Text;
            string segundoNombre = this.txtSegundoNombre.Text;
            string primerApellido = this.txtPrimerApellido.Text;
            string segundoApellido = this.txtSegundoApellido.Text;
            string correo = this.txtCorreo.Text;
            string telefono = this.txtTelefono.Text;

            CEmpleados.SaveEmpleado(primerNombre, segundoNombre, primerApellido, segundoApellido, correo, telefono);
            MessageBox.Show("Empleado agregado correctamente");

            MostrarEmpleado();

        }
        public void MostrarEmpleado()
        {
            var empleados = CEmpleados.ShowAllPeople();
            this.DataEmpleados.DataSource = empleados;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();

        }
    }
}
