namespace GUI_V_2.Vista
{
    partial class FormProducto
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(918, 260);
            this.dataGridViewProductos.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnGuardar.Location = new System.Drawing.Point(181, 447);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 54);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnNuevo.Location = new System.Drawing.Point(18, 447);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(147, 54);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(210, 298);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(184, 22);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(88, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(210, 338);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 22);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(460, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Marca";
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Location = new System.Drawing.Point(210, 379);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(184, 22);
            this.txtCantidadDisponible.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(465, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(537, 339);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(184, 22);
            this.txtPrecio.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(422, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categoria ";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(537, 299);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(184, 22);
            this.txtCategoria.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(8, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cantidad Disponible";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(537, 378);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(184, 22);
            this.txtMarca.TabIndex = 18;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnActualizar.Location = new System.Drawing.Point(350, 447);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(147, 54);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(572, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Barra de Busqueda";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridViewProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}