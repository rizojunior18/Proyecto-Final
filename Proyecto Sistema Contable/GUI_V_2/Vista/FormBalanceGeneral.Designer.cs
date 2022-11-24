namespace GUI_V_2.Vista
{
    partial class FormBalanceGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repositorioBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioBalanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioBalanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositorioBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioBalanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioBalanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.Location = new System.Drawing.Point(3, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(924, 514);
            this.pnlPrincipal.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.DocumentMapWidth = 8;
            reportDataSource1.Name = "Cuenta2";
            reportDataSource1.Value = this.repositorioBalanceBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.repositorioBalanceBindingSource1;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.repositorioBalanceBindingSource2;
            reportDataSource4.Name = "DataSet3";
            reportDataSource4.Value = this.repositorioEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.ReporteBG.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(923, 550);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // repositorioBalanceBindingSource
            // 
            this.repositorioBalanceBindingSource.DataSource = typeof(GUI_V_2.Controlador.RepositorioBalance);
            this.repositorioBalanceBindingSource.CurrentChanged += new System.EventHandler(this.repositorioBalanceBindingSource_CurrentChanged);
            // 
            // repositorioBalanceBindingSource1
            // 
            this.repositorioBalanceBindingSource1.DataSource = typeof(GUI_V_2.Controlador.RepositorioBalance);
            // 
            // repositorioBalanceBindingSource2
            // 
            this.repositorioBalanceBindingSource2.DataSource = typeof(GUI_V_2.Controlador.RepositorioBalance);
            // 
            // repositorioEmpresaBindingSource
            // 
            this.repositorioEmpresaBindingSource.DataSource = typeof(GUI_V_2.Controlador.RepositorioEmpresa);
            // 
            // FormBalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 559);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FormBalanceGeneral";
            this.Text = "FormBalanceGeneral";
            this.Load += new System.EventHandler(this.FormBalanceGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositorioBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioBalanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioBalanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource repositorioBalanceBindingSource;
        private System.Windows.Forms.BindingSource repositorioBalanceBindingSource1;
        private System.Windows.Forms.BindingSource repositorioBalanceBindingSource2;
        private System.Windows.Forms.BindingSource repositorioEmpresaBindingSource;
    }
}