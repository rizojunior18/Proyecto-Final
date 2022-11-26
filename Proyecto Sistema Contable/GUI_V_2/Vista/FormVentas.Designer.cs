namespace GUI_V_2.Vista
{
    partial class FormVentas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.dataFactura = new System.Windows.Forms.DataGridView();
            this.dataProductosVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button2.Location = new System.Drawing.Point(705, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 51);
            this.button2.TabIndex = 27;
            this.button2.Text = "Confirmar la compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnCancelarCompra.Location = new System.Drawing.Point(806, 488);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(96, 50);
            this.btnCancelarCompra.TabIndex = 26;
            this.btnCancelarCompra.Text = "Cancelar la compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(114, 517);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(123, 22);
            this.txtApellidoCliente.TabIndex = 22;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(114, 545);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(123, 22);
            this.txtCedulaCliente.TabIndex = 21;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(114, 489);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(123, 22);
            this.txtNombreCliente.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(456, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(565, 232);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(175, 22);
            this.txtBusqueda.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnCancelar.Location = new System.Drawing.Point(827, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnAnadir.Location = new System.Drawing.Point(746, 231);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 16;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            // 
            // dataFactura
            // 
            this.dataFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFactura.Location = new System.Drawing.Point(12, 279);
            this.dataFactura.Name = "dataFactura";
            this.dataFactura.RowHeadersWidth = 51;
            this.dataFactura.RowTemplate.Height = 24;
            this.dataFactura.Size = new System.Drawing.Size(900, 189);
            this.dataFactura.TabIndex = 15;
            // 
            // dataProductosVentas
            // 
            this.dataProductosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductosVentas.Location = new System.Drawing.Point(12, 18);
            this.dataProductosVentas.Name = "dataProductosVentas";
            this.dataProductosVentas.RowHeadersWidth = 51;
            this.dataProductosVentas.RowTemplate.Height = 24;
            this.dataProductosVentas.Size = new System.Drawing.Size(900, 189);
            this.dataProductosVentas.TabIndex = 14;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.dataFactura);
            this.Controls.Add(this.dataProductosVentas);
            this.Name = "FormVentas";
            this.Size = new System.Drawing.Size(924, 585);
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.DataGridView dataFactura;
        private System.Windows.Forms.DataGridView dataProductosVentas;
    }
}
