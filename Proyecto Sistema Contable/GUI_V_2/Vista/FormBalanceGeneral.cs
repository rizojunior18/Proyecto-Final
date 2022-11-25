using GUI_V_2.Controlador;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GUI_V_2.Vista
{
    public partial class FormBalanceGeneral : Form
    {
   
        public FormBalanceGeneral()
        {
            InitializeComponent();
            RepositorioBalance objRepo = new RepositorioBalance();
            RepositorioEmpresa objEmpresa = new RepositorioEmpresa();


            repositorioBalanceBindingSource.DataSource = objRepo.ReadActivo;
            repositorioBalanceBindingSource1.DataSource = objRepo.ReadPasivo;
            repositorioBalanceBindingSource2.DataSource = objRepo.ReadCapital;
            repositorioEmpresaBindingSource.DataSource = objEmpresa.Read;

            this.reportViewer1.RefreshReport();
        }

        private void FormBalanceGeneral_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }

        private void repositorioBalanceBindingSource_CurrentChanged(object sender, EventArgs e)
        {
          
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
