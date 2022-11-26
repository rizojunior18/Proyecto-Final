using GUI_V_2.Controlador;
using GUI_V_2.Modelo;
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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
           
        }
        public void MostrarUsuarios()
        {
            var usuarios = CUsuario.ShowUsuarios();
            this.DataUsuarios.DataSource = usuarios;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombreUsuario.Text) && string.IsNullOrEmpty(txtBusquedaUsuario.Text)
                && string.IsNullOrEmpty(txtRolUsuario.Text) && string.IsNullOrEmpty(txtTipoPermiso.Text)
                && string.IsNullOrEmpty(txtContrasena.Text) && string.IsNullOrEmpty(txtIdEmpleado.Text)
                )
            {

                MessageBox.Show("Por favor ingrese todos los datos en los campos");

                return;

            }
            else {
                string username = this.txtNombreUsuario.Text;
                string password = this.txtContrasena.Text;
                int permiso = Convert.ToInt32(this.txtTipoPermiso.Text);
                string roleuser = this.txtRolUsuario.Text;
                int idPersona = Convert.ToInt32(this.txtIdEmpleado.Text);

                CUsuario.SaveUsuario(idPersona, username, password, permiso, roleuser);
                MessageBox.Show("Usuario creado correctamente ");

                MostrarUsuarios();
            }
            

        }

        
        

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            HabilitarTextbox(true);
            //this.btnNuevoUsuario.Enabled = true;
        }

        public void LimpiarTextbox()
        {
            this.txtNombreUsuario.Text = String.Empty;
            this.txtContrasena.Text = String.Empty;
            this.txtTipoPermiso.Text = String.Empty;
            this.txtRolUsuario.Text = String.Empty;
            this.txtIdEmpleado.Text = String.Empty;
            this.txtBusquedaUsuario.Text = String.Empty;



            // this.txtEstado.Text = String.Empty;
            this.DataUsuarios.ClearSelection();
        }
        public void HabilitarTextbox(bool dato)
        {
            this.txtNombreUsuario.Enabled = dato;
            this.txtContrasena.Enabled = dato;
            this.txtTipoPermiso.Enabled = dato;
            this.txtRolUsuario.Enabled = dato;
            this.txtIdEmpleado.Enabled = dato;
            this.txtBusquedaUsuario.Enabled = dato;


            // this.txtEstado.Text = String.Empty;

        }
        public void ControlBotones(string dato)
        {
            if (dato == "Nuevo")
            {

                this.HabilitarTextbox(false);
                this.LimpiarTextbox();
                this.btnNuevoUsuario.Enabled = true;
                this.btnGuardarUsuario.Enabled = true;
                this.btnActualizarUsuario.Enabled = false;
                this.btnEliminarUsuario.Enabled = false;


            }
            else
            if (dato == "Guardar")
            {

                this.HabilitarTextbox(true);
                this.btnNuevoUsuario.Enabled = true;
                this.btnGuardarUsuario.Enabled = true;
                this.btnActualizarUsuario.Enabled = false;
                this.btnEliminarUsuario.Enabled = false;


            }

            else
            if (dato == "Actualizar")
            {

                this.HabilitarTextbox(true);
                this.btnNuevoUsuario.Enabled = true;
                this.btnGuardarUsuario.Enabled = true;
                this.btnActualizarUsuario.Enabled = false;
                this.btnEliminarUsuario.Enabled = false;

            }
            else
            if (dato == "Eliminar")
            {

                this.HabilitarTextbox(true);
                this.btnNuevoUsuario.Enabled = true;
                this.btnGuardarUsuario.Enabled = true;
                this.btnActualizarUsuario.Enabled = false;
                this.btnEliminarUsuario.Enabled = false;


            }


        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string userName = this.txtNombreUsuario.Text;

            CUsuario.EliminarUsuario(userName);

            MessageBox.Show("El usuario se ha eliminado exitosamente");

            MostrarUsuarios();

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
