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
    public partial class EstadoResultado : Form
    {
        public EstadoResultado()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnER_Click(object sender, EventArgs e)
        {

            if(txtVentas.Text=="" || txtCostoVenta.Text==""|| txtGtoFinanciero.Text=="" ||
                txtGtoOperacion.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double descuento = Double.Parse(txtDesc.Text); ;
            double devoluciones = Double.Parse(txtDev.Text);
            double ventas = Double.Parse(txtVentas.Text);
            double costoVentas  = Double.Parse(txtCostoVenta.Text);
            double gtoOperacion= Double.Parse(txtGtoOperacion.Text);
            double gtoFinanciero = Double.Parse(txtGtoFinanciero.Text);
            

            if (txtDesc.Text == ""){descuento = 0;}
            if (txtDev.Text == ""){devoluciones = 0;}

            if (devoluciones + descuento > ventas) {
                MessageBox.Show("La sumatoria de las devoluciones y descuentos no debe ser mayor a las ventas");
                return;
            }

            EstadoR objEstado = new EstadoR();
          
            double utilidadAntesImpuestos = objEstado.calcularUtilidadAntesImpuestos(
                objEstado.calcularUtilidadOperacional(
                objEstado.calcularUtilidadBruta(costoVentas, objEstado.calcularVentasNetas(ventas, devoluciones, descuento)),
                gtoOperacion), gtoFinanciero);

            double impuestos = objEstado.calcularIR(utilidadAntesImpuestos);

            lblEmpresa.Text = txtEmpresa.Text;
            lbfecha.Text = txtFecha.Text;
            lblVentas.Text = "Ventas: " + ventas;
            lblDev.Text = "Devoluciones S/V: " + devoluciones;
            lblDesc.Text = "Descuentos: " + descuento;
            lblVentasNetas.Text = "Ventas netas: " + objEstado.calcularVentasNetas(ventas, devoluciones, descuento);
            lblCostoV.Text = "Costo de ventas: " + costoVentas;
            lblUtBruta.Text = "Utilidad bruta: " + objEstado.calcularUtilidadBruta(costoVentas, objEstado.calcularVentasNetas(ventas, devoluciones, descuento));
            lblGtoOperacion.Text = "Gasto de operación: " + gtoOperacion;
            lblUtilidadOperacion.Text = "Utilidad operacional: " + objEstado.calcularUtilidadOperacional(
                objEstado.calcularUtilidadBruta(costoVentas, objEstado.calcularVentasNetas(ventas, devoluciones, descuento)),
                gtoOperacion);
            lblGtoFin.Text = "Gastos financieros: " + gtoFinanciero;
            lblUAI.Text = "Utilidad antes de impuestos: " + utilidadAntesImpuestos;
            lbIR.Text = "IR 30%: " + impuestos;
            lblUtilidadNeta.Text = "Utilidad neta: " + (utilidadAntesImpuestos - impuestos);




        }


        private void validarNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        private void txtDev_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

        }

        private void txtCostoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

        }

        private void txtGtoOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

        }

        private void txtGtoFinanciero_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);

        }
    }
}
