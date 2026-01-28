namespace CapaPresentacion
{
    partial class FrmRegistrarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsku = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfechavencimiento = new System.Windows.Forms.TextBox();
            this.txtfechaingreso = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserte los datos del producto a registrar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código (SKU)";
            // 
            // txtsku
            // 
            this.txtsku.Location = new System.Drawing.Point(17, 100);
            this.txtsku.Name = "txtsku";
            this.txtsku.Size = new System.Drawing.Size(244, 22);
            this.txtsku.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(17, 178);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(244, 22);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(17, 272);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(244, 22);
            this.txtdescripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha ingreso";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha vencimiento";
            // 
            // txtfechavencimiento
            // 
            this.txtfechavencimiento.Location = new System.Drawing.Point(363, 178);
            this.txtfechavencimiento.Name = "txtfechavencimiento";
            this.txtfechavencimiento.Size = new System.Drawing.Size(244, 22);
            this.txtfechavencimiento.TabIndex = 10;
            // 
            // txtfechaingreso
            // 
            this.txtfechaingreso.Location = new System.Drawing.Point(363, 100);
            this.txtfechaingreso.Name = "txtfechaingreso";
            this.txtfechaingreso.Size = new System.Drawing.Size(244, 22);
            this.txtfechaingreso.TabIndex = 9;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(363, 350);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(244, 22);
            this.txtprecioventa.TabIndex = 12;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(363, 272);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(244, 22);
            this.txtpreciocompra.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(17, 348);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(244, 22);
            this.txtstock.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(97, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(17, 416);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(244, 22);
            this.txtestado.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources._8071a0cea669dc5d940ed2e72760e752;
            this.pictureBox1.Location = new System.Drawing.Point(705, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 664);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 737);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.txtfechavencimiento);
            this.Controls.Add(this.txtfechaingreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsku;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfechavencimiento;
        private System.Windows.Forms.TextBox txtfechaingreso;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}