namespace GUI_V_2.Vista
{
    partial class EstadoResultado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.txtCostoVenta = new System.Windows.Forms.TextBox();
            this.txtGtoOperacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGtoFinanciero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnER = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblEr = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblVentasNetas = new System.Windows.Forms.Label();
            this.lblCostoV = new System.Windows.Forms.Label();
            this.lblUtBruta = new System.Windows.Forms.Label();
            this.lblGtoFin = new System.Windows.Forms.Label();
            this.lblUAI = new System.Windows.Forms.Label();
            this.lbIR = new System.Windows.Forms.Label();
            this.lblUtilidadNeta = new System.Windows.Forms.Label();
            this.lblGtoOperacion = new System.Windows.Forms.Label();
            this.lblUtilidadOperacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmpresa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.btnER);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGtoFinanciero);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGtoOperacion);
            this.panel1.Controls.Add(this.txtCostoVenta);
            this.panel1.Controls.Add(this.txtDev);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.txtVentas);
            this.panel1.Location = new System.Drawing.Point(550, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 570);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lblUtilidadOperacion);
            this.panel2.Controls.Add(this.lblGtoOperacion);
            this.panel2.Controls.Add(this.lblUtilidadNeta);
            this.panel2.Controls.Add(this.lbIR);
            this.panel2.Controls.Add(this.lblUAI);
            this.panel2.Controls.Add(this.lblGtoFin);
            this.panel2.Controls.Add(this.lblUtBruta);
            this.panel2.Controls.Add(this.lblCostoV);
            this.panel2.Controls.Add(this.lblVentasNetas);
            this.panel2.Controls.Add(this.lblDesc);
            this.panel2.Controls.Add(this.lblDev);
            this.panel2.Controls.Add(this.lblVentas);
            this.panel2.Controls.Add(this.lbfecha);
            this.panel2.Controls.Add(this.lblEr);
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Location = new System.Drawing.Point(31, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 491);
            this.panel2.TabIndex = 1;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(197, 183);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 20);
            this.txtVentas.TabIndex = 0;
            this.txtVentas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVentas_KeyPress);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(197, 262);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(197, 221);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(100, 20);
            this.txtDev.TabIndex = 2;
            this.txtDev.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtDev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDev_KeyPress);
            // 
            // txtCostoVenta
            // 
            this.txtCostoVenta.Location = new System.Drawing.Point(197, 301);
            this.txtCostoVenta.Name = "txtCostoVenta";
            this.txtCostoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtCostoVenta.TabIndex = 3;
            this.txtCostoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoVenta_KeyPress);
            // 
            // txtGtoOperacion
            // 
            this.txtGtoOperacion.Location = new System.Drawing.Point(197, 337);
            this.txtGtoOperacion.Name = "txtGtoOperacion";
            this.txtGtoOperacion.Size = new System.Drawing.Size(100, 20);
            this.txtGtoOperacion.TabIndex = 4;
            this.txtGtoOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGtoOperacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(61, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(61, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Devoluciones S/V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(61, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descuento S/V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(61, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Costo de venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(61, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gto de operación";
            // 
            // txtGtoFinanciero
            // 
            this.txtGtoFinanciero.Location = new System.Drawing.Point(197, 374);
            this.txtGtoFinanciero.Name = "txtGtoFinanciero";
            this.txtGtoFinanciero.Size = new System.Drawing.Size(100, 20);
            this.txtGtoFinanciero.TabIndex = 11;
            this.txtGtoFinanciero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGtoFinanciero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(61, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gtos financieros";
            // 
            // btnER
            // 
            this.btnER.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnER.Location = new System.Drawing.Point(38, 429);
            this.btnER.Name = "btnER";
            this.btnER.Size = new System.Drawing.Size(290, 60);
            this.btnER.TabIndex = 13;
            this.btnER.Text = "Realizar Estado de Resultados";
            this.btnER.UseVisualStyleBackColor = false;
            this.btnER.Click += new System.EventHandler(this.btnER_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(197, 136);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(61, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(197, 92);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(61, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Empresa";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpresa.Location = new System.Drawing.Point(212, 33);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(63, 17);
            this.lblEmpresa.TabIndex = 19;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblEr
            // 
            this.lblEr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEr.AutoSize = true;
            this.lblEr.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEr.Location = new System.Drawing.Point(170, 54);
            this.lblEr.Name = "lblEr";
            this.lblEr.Size = new System.Drawing.Size(142, 17);
            this.lblEr.TabIndex = 20;
            this.lblEr.Text = "Estado de resultados";
            // 
            // lbfecha
            // 
            this.lbfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbfecha.Location = new System.Drawing.Point(179, 81);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(124, 17);
            this.lbfecha.TabIndex = 21;
            this.lbfecha.Text = "31 de dic. de 2022";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVentas.Location = new System.Drawing.Point(41, 122);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(52, 17);
            this.lblVentas.TabIndex = 18;
            this.lblVentas.Text = "Ventas";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDev.Location = new System.Drawing.Point(41, 150);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(120, 17);
            this.lblDev.TabIndex = 18;
            this.lblDev.Text = "Devoluciones S/V";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(41, 183);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(102, 17);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Descuento S/V";
            // 
            // lblVentasNetas
            // 
            this.lblVentasNetas.AutoSize = true;
            this.lblVentasNetas.Font = new System.Drawing.Font("Century Gothic", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasNetas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVentasNetas.Location = new System.Drawing.Point(41, 214);
            this.lblVentasNetas.Name = "lblVentasNetas";
            this.lblVentasNetas.Size = new System.Drawing.Size(96, 17);
            this.lblVentasNetas.TabIndex = 22;
            this.lblVentasNetas.Text = "Ventas Netas";
            // 
            // lblCostoV
            // 
            this.lblCostoV.AutoSize = true;
            this.lblCostoV.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCostoV.Location = new System.Drawing.Point(41, 243);
            this.lblCostoV.Name = "lblCostoV";
            this.lblCostoV.Size = new System.Drawing.Size(115, 17);
            this.lblCostoV.TabIndex = 23;
            this.lblCostoV.Text = "Costo de ventas";
            // 
            // lblUtBruta
            // 
            this.lblUtBruta.AutoSize = true;
            this.lblUtBruta.Font = new System.Drawing.Font("Century Gothic", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtBruta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUtBruta.Location = new System.Drawing.Point(41, 276);
            this.lblUtBruta.Name = "lblUtBruta";
            this.lblUtBruta.Size = new System.Drawing.Size(98, 17);
            this.lblUtBruta.TabIndex = 24;
            this.lblUtBruta.Text = "Utilidad bruta";
            // 
            // lblGtoFin
            // 
            this.lblGtoFin.AutoSize = true;
            this.lblGtoFin.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGtoFin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGtoFin.Location = new System.Drawing.Point(41, 372);
            this.lblGtoFin.Name = "lblGtoFin";
            this.lblGtoFin.Size = new System.Drawing.Size(125, 17);
            this.lblGtoFin.TabIndex = 25;
            this.lblGtoFin.Text = "Gastos financieros";
            // 
            // lblUAI
            // 
            this.lblUAI.AutoSize = true;
            this.lblUAI.Font = new System.Drawing.Font("Century Gothic", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUAI.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUAI.Location = new System.Drawing.Point(41, 409);
            this.lblUAI.Name = "lblUAI";
            this.lblUAI.Size = new System.Drawing.Size(195, 17);
            this.lblUAI.TabIndex = 26;
            this.lblUAI.Text = "Utilidad antes de impuestos";
            // 
            // lbIR
            // 
            this.lbIR.AutoSize = true;
            this.lbIR.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIR.ForeColor = System.Drawing.SystemColors.Control;
            this.lbIR.Location = new System.Drawing.Point(41, 431);
            this.lbIR.Name = "lbIR";
            this.lbIR.Size = new System.Drawing.Size(47, 17);
            this.lbIR.TabIndex = 27;
            this.lbIR.Text = "IR 30%";
            // 
            // lblUtilidadNeta
            // 
            this.lblUtilidadNeta.AutoSize = true;
            this.lblUtilidadNeta.Font = new System.Drawing.Font("Century Gothic", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadNeta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUtilidadNeta.Location = new System.Drawing.Point(41, 461);
            this.lblUtilidadNeta.Name = "lblUtilidadNeta";
            this.lblUtilidadNeta.Size = new System.Drawing.Size(94, 17);
            this.lblUtilidadNeta.TabIndex = 28;
            this.lblUtilidadNeta.Text = "Utilidad neta";
            // 
            // lblGtoOperacion
            // 
            this.lblGtoOperacion.AutoSize = true;
            this.lblGtoOperacion.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGtoOperacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGtoOperacion.Location = new System.Drawing.Point(41, 312);
            this.lblGtoOperacion.Name = "lblGtoOperacion";
            this.lblGtoOperacion.Size = new System.Drawing.Size(144, 17);
            this.lblGtoOperacion.TabIndex = 29;
            this.lblGtoOperacion.Text = "Gastos de operación";
            // 
            // lblUtilidadOperacion
            // 
            this.lblUtilidadOperacion.AutoSize = true;
            this.lblUtilidadOperacion.Font = new System.Drawing.Font("Century Gothic", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadOperacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUtilidadOperacion.Location = new System.Drawing.Point(41, 345);
            this.lblUtilidadOperacion.Name = "lblUtilidadOperacion";
            this.lblUtilidadOperacion.Size = new System.Drawing.Size(147, 17);
            this.lblUtilidadOperacion.TabIndex = 30;
            this.lblUtilidadOperacion.Text = "Utilidad operacional";
            // 
            // EstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(923, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstadoResultado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EstadoResultado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGtoOperacion;
        private System.Windows.Forms.TextBox txtCostoVenta;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGtoFinanciero;
        private System.Windows.Forms.Label lblUtilidadNeta;
        private System.Windows.Forms.Label lbIR;
        private System.Windows.Forms.Label lblUAI;
        private System.Windows.Forms.Label lblGtoFin;
        private System.Windows.Forms.Label lblUtBruta;
        private System.Windows.Forms.Label lblCostoV;
        private System.Windows.Forms.Label lblVentasNetas;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lblEr;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblUtilidadOperacion;
        private System.Windows.Forms.Label lblGtoOperacion;
    }
}