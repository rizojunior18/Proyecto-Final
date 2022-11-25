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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_V_2.Vista
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtFecha.Text=="" || txtNombre.Text=="")
            {
                MessageBox.Show("Hacen falta campos por rellenar");
                return;
            }

            Modelo.Empresa empresas = new Modelo.Empresa();
            RepositorioEmpresa objRepo = new RepositorioEmpresa();
            empresas.nombre = txtNombre.Text;
            empresas.fecha = txtFecha.Text;
            objRepo.Crear(empresas);

            FormBalanceGeneral formBG = new FormBalanceGeneral();

            formBG.Show();
        }
    }
}
