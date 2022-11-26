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
            HabilitarTextbox(false);

        }
        public void LimpiarTextbox()
        {
            this.txtPrimerNombre.Text = String.Empty;
            this.txtSegundoNombre.Text = String.Empty;
            this.txtPrimerApellido.Text = String.Empty;
            this.txtSegundoApellido.Text = String.Empty;
            this.txtCorreo.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.txtBusqueda.Text = String.Empty;


            // this.txtEstado.Text = String.Empty;
            this.DataEmpleados.ClearSelection();
        }
        public void HabilitarTextbox(bool dato)
        {
            this.txtPrimerNombre.Enabled = dato;
            this.txtSegundoNombre.Enabled = dato;
            this.txtPrimerApellido.Enabled = dato;
            this.txtSegundoApellido.Enabled = dato;
            this.txtCorreo.Enabled = dato;
            this.txtTelefono.Enabled = dato;


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
                this.btnActualizar.Enabled = false;


            }

            else
            if (dato == "Actualizar")
            {

                this.HabilitarTextbox(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnActualizar.Enabled = true;


            }



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlBotones("Nuevo");
        }
    }
}
