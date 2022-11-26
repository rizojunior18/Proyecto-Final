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
            string username = this.txtNombreUsuario.Text;
            string password = this.txtContrasena.Text;
            int permiso = Convert.ToInt32(this.txtTipoPermiso.Text);
            string roleuser = this.txtRolUsuario.Text;
            int idPersona = Convert.ToInt32(this.txtIdEmpleado.Text);

            CUsuario.SaveUsuario(idPersona, username, password, permiso, roleuser);
            MessageBox.Show("Usuario creado correctamente ");

            MostrarUsuarios();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
    }
}
