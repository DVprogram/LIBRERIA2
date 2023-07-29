namespace LIBRERIA2.VISTAS
{
    partial class EditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProducto));
            this.paneleditar = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.TextBox();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txrprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxmarca = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnguardareditado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.paneleditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneleditar
            // 
            this.paneleditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.paneleditar.Controls.Add(this.ID);
            this.paneleditar.Controls.Add(this.cbxcategoria);
            this.paneleditar.Controls.Add(this.pictureBox1);
            this.paneleditar.Controls.Add(this.label2);
            this.paneleditar.Controls.Add(this.txtcantidad);
            this.paneleditar.Controls.Add(this.txrprecio);
            this.paneleditar.Controls.Add(this.label5);
            this.paneleditar.Controls.Add(this.label4);
            this.paneleditar.Controls.Add(this.cbxmarca);
            this.paneleditar.Controls.Add(this.lblcategoria);
            this.paneleditar.Controls.Add(this.label1);
            this.paneleditar.Controls.Add(this.btncerrar);
            this.paneleditar.Controls.Add(this.txtprecioventa);
            this.paneleditar.Controls.Add(this.txtProducto);
            this.paneleditar.Controls.Add(this.btnguardareditado);
            this.paneleditar.Controls.Add(this.label3);
            this.paneleditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneleditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneleditar.Location = new System.Drawing.Point(0, 0);
            this.paneleditar.Name = "paneleditar";
            this.paneleditar.Size = new System.Drawing.Size(607, 323);
            this.paneleditar.TabIndex = 6;
            this.paneleditar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneleditar_Paint);
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Location = new System.Drawing.Point(380, 162);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(177, 26);
            this.ID.TabIndex = 31;
            this.ID.Visible = false;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(380, 113);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(175, 28);
            this.cbxcategoria.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Location = new System.Drawing.Point(129, 67);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(177, 26);
            this.txtcantidad.TabIndex = 27;
            // 
            // txrprecio
            // 
            this.txrprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txrprecio.Location = new System.Drawing.Point(129, 115);
            this.txrprecio.Name = "txrprecio";
            this.txrprecio.Size = new System.Drawing.Size(177, 26);
            this.txrprecio.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Categoria:";
            // 
            // cbxmarca
            // 
            this.cbxmarca.FormattingEnabled = true;
            this.cbxmarca.Location = new System.Drawing.Point(380, 44);
            this.cbxmarca.Name = "cbxmarca";
            this.cbxmarca.Size = new System.Drawing.Size(175, 28);
            this.cbxmarca.TabIndex = 20;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(376, 21);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(57, 20);
            this.lblcategoria.TabIndex = 18;
            this.lblcategoria.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producto";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(185)))));
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(443, 243);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(112, 38);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.Text = "Cancelar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioventa.Location = new System.Drawing.Point(129, 156);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(177, 26);
            this.txtprecioventa.TabIndex = 7;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(129, 24);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(177, 26);
            this.txtProducto.TabIndex = 6;
            // 
            // btnguardareditado
            // 
            this.btnguardareditado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(185)))));
            this.btnguardareditado.FlatAppearance.BorderSize = 0;
            this.btnguardareditado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardareditado.ForeColor = System.Drawing.Color.White;
            this.btnguardareditado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardareditado.Location = new System.Drawing.Point(306, 243);
            this.btnguardareditado.Name = "btnguardareditado";
            this.btnguardareditado.Size = new System.Drawing.Size(112, 38);
            this.btnguardareditado.TabIndex = 4;
            this.btnguardareditado.Text = "Guardar";
            this.btnguardareditado.UseVisualStyleBackColor = false;
            this.btnguardareditado.Click += new System.EventHandler(this.btnguardareditado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio Venta";
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 323);
            this.Controls.Add(this.paneleditar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.paneleditar.ResumeLayout(false);
            this.paneleditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneleditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnguardareditado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.ComboBox cbxcategoria;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.TextBox txrprecio;
        public System.Windows.Forms.ComboBox cbxmarca;
        public System.Windows.Forms.TextBox txtprecioventa;
        public System.Windows.Forms.TextBox ID;
    }
}