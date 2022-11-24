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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtContra.Text=="password" && txtUsuario.Text == "user") {
                MessageBox.Show("Bienvenido, " + txtUsuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1= new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
                return;
            }
            MessageBox.Show("Credenciales incorrectas","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
