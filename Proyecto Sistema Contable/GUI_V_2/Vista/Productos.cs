using GUI_V_2.Controlador;
using GUI_V_2.Modelo;
using GUI_V_2.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa = GUI_V_2.Vista.Empresa;

namespace GUI_V_2
{
    public partial class Productos : Form
    {
        RepositorioCuenta repoCuenta = new RepositorioCuenta();
        RepositorioBalance objRepos = new RepositorioBalance();

        List<Cuenta> lstCuenta = new List<Cuenta>();

        public Productos()
        {
            InitializeComponent();
            //llenarCombobox();
            lstCuenta = repoCuenta.llenarCuentas();
            cmbCuentas.DataSource = lstCuenta;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCuentas_Format(object sender, ListControlConvertEventArgs e)
        {
            string valor = ((Cuenta)e.ListItem).nombreCuenta.ToString();
            e.Value = valor;
        }

        

        private void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //MessageBox.Show(((Cuenta)(((ComboBox)sender).SelectedValue)).nombreCuenta);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cuentas = comboBox1.SelectedItem.ToString();
            List<Cuenta> lstDependencia = new List<Cuenta>();
            lstDependencia = lstCuenta.Where(item => item.tipoCuenta == cuentas).ToList();
            cmbCuentas.DataSource = lstDependencia;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CuentaBalance cuentaBalance = new CuentaBalance();
            RepositorioBalance objRepo = new RepositorioBalance();
            cuentaBalance.tipoCuenta = comboBox1.SelectedItem.ToString();
            cuentaBalance.nombreCuenta = ((Cuenta)(((cmbCuentas)).SelectedValue)).nombreCuenta;
            cuentaBalance.monto = Double.Parse(textBox3.Text.ToString());

            if (objRepo.ValidarCuenta(cuentaBalance)==true)
            {
                MessageBox.Show("No se pueden repetir las cuentas");
                return;
            }

            objRepo.Crear(cuentaBalance);
            dgvCuentas.DataSource = objRepo.Read;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RepositorioBalance objRepo = new RepositorioBalance();
            objRepo.Eliminar();
            dgvCuentas.DataSource = objRepo.Read;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RepositorioBalance objRepo = new RepositorioBalance();
            if(objRepo.ReadActivo.Sum(item=>item.monto)< 
                (objRepo.ReadPasivo.Sum(item => item.monto)+ objRepo.ReadCapital.Sum(item => item.monto)))
                {
                MessageBox.Show("Error en el ejercicio, el monto de activos es inferior al monto" +
                    " de la sumatoria de pasivo y patrimonio");
                return;
            }
            FormBalanceGeneral formBG = new FormBalanceGeneral();
            Empresa formEmpresa = new  Empresa();
            formEmpresa.Show();
            //formBG.Show();
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Excel | *.xls;*.xlsx;",
                    Title = "Seleccionar Archivo"
                };
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    //obj_repositorio.Read = null;
                    objRepos.ImportarDatos(openFileDialog.FileName);
                    dgvCuentas.DataSource = null;
                    dgvCuentas.DataSource = objRepos.Read;
                    //MessageBox.Show("Count: " + lista[0].nombre);

                    /*foreach (var item in lista)
                    {
                        objRepo.Crear(item);
                    }
                    //objRepo.BulkCreate(lista);
                    
                    datagridP.ItemsSource = null;
                    datagridP.ItemsSource = objRepo.Read;
                    objRepo.calcularDatosRelevantes(tbProductos, tbTotales, tbCostoTotalCompra, tbcMasExistencias);
                    */

                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.ToString()); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
