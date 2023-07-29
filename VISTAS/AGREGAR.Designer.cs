namespace LIBRERIA2.VISTAS
{
    partial class AGREGAR
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
            this.panelproductos = new System.Windows.Forms.Panel();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelproductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelproductos
            // 
            this.panelproductos.Controls.Add(this.cbxcategoria);
            this.panelproductos.Controls.Add(this.lblcategoria);
            this.panelproductos.Controls.Add(this.label1);
            this.panelproductos.Controls.Add(this.btnvolver);
            this.panelproductos.Controls.Add(this.txtprecio);
            this.panelproductos.Controls.Add(this.txtProducto);
            this.panelproductos.Controls.Add(this.btnGuardar);
            this.panelproductos.Controls.Add(this.label3);
            this.panelproductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelproductos.Location = new System.Drawing.Point(0, 0);
            this.panelproductos.Name = "panelproductos";
            this.panelproductos.Size = new System.Drawing.Size(547, 294);
            this.panelproductos.TabIndex = 4;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(147, 103);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(255, 28);
            this.cbxcategoria.TabIndex = 19;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(48, 103);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(78, 20);
            this.lblcategoria.TabIndex = 18;
            this.lblcategoria.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producto";
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(282, 228);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(120, 38);
            this.btnvolver.TabIndex = 9;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(150, 63);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(245, 26);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(150, 24);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(245, 26);
            this.txtProducto.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(147, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio";
            // 
            // AGREGAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelproductos);
            this.Name = "AGREGAR";
            this.Size = new System.Drawing.Size(547, 294);
            this.panelproductos.ResumeLayout(false);
            this.panelproductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelproductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.Label lblcategoria;
    }
}
