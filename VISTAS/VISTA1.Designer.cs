namespace LIBRERIA2
{
    partial class VISTA1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelproductos = new System.Windows.Forms.Panel();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.dtresultadobusqueda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnGuardarcambios = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.cbxfiltro = new System.Windows.Forms.ComboBox();
            this.panelproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtresultadobusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelproductos
            // 
            this.panelproductos.Controls.Add(this.cbxcategoria);
            this.panelproductos.Controls.Add(this.lblcategoria);
            this.panelproductos.Controls.Add(this.dtresultadobusqueda);
            this.panelproductos.Controls.Add(this.label1);
            this.panelproductos.Controls.Add(this.btnvolver);
            this.panelproductos.Controls.Add(this.btnGuardarcambios);
            this.panelproductos.Controls.Add(this.txtprecio);
            this.panelproductos.Controls.Add(this.txtProducto);
            this.panelproductos.Controls.Add(this.btnGuardar);
            this.panelproductos.Controls.Add(this.label3);
            this.panelproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelproductos.Location = new System.Drawing.Point(12, 25);
            this.panelproductos.Name = "panelproductos";
            this.panelproductos.Size = new System.Drawing.Size(539, 382);
            this.panelproductos.TabIndex = 3;
            this.panelproductos.Visible = false;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(150, 121);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(255, 28);
            this.cbxcategoria.TabIndex = 17;
            this.cbxcategoria.SelectedIndexChanged += new System.EventHandler(this.cbxcategoria_SelectedIndexChanged);
            this.cbxcategoria.Leave += new System.EventHandler(this.cbxcategoria_Leave);
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(51, 121);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(78, 20);
            this.lblcategoria.TabIndex = 14;
            this.lblcategoria.Text = "Categoria";
            // 
            // dtresultadobusqueda
            // 
            this.dtresultadobusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtresultadobusqueda.Location = new System.Drawing.Point(121, 178);
            this.dtresultadobusqueda.Name = "dtresultadobusqueda";
            this.dtresultadobusqueda.Size = new System.Drawing.Size(369, 125);
            this.dtresultadobusqueda.TabIndex = 12;
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
            this.btnvolver.Location = new System.Drawing.Point(411, 309);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(120, 38);
            this.btnvolver.TabIndex = 9;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // btnGuardarcambios
            // 
            this.btnGuardarcambios.Location = new System.Drawing.Point(257, 309);
            this.btnGuardarcambios.Name = "btnGuardarcambios";
            this.btnGuardarcambios.Size = new System.Drawing.Size(148, 38);
            this.btnGuardarcambios.TabIndex = 8;
            this.btnGuardarcambios.Text = "Guardar Cambios";
            this.btnGuardarcambios.UseVisualStyleBackColor = true;
            this.btnGuardarcambios.Visible = false;
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
            this.txtProducto.Leave += new System.EventHandler(this.txtProducto_Leave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(143, 309);
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
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(577, 51);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(115, 32);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.Location = new System.Drawing.Point(557, 128);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(245, 20);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(673, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(557, 217);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 20);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Filtrar";
            // 
            // cbxfiltro
            // 
            this.cbxfiltro.FormattingEnabled = true;
            this.cbxfiltro.Location = new System.Drawing.Point(612, 219);
            this.cbxfiltro.Name = "cbxfiltro";
            this.cbxfiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxfiltro.TabIndex = 16;
            this.cbxfiltro.SelectedIndexChanged += new System.EventHandler(this.cbxfiltro_SelectedIndexChanged);
            // 
            // VISTA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxfiltro);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.panelproductos);
            this.Name = "VISTA1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VISTA1_Load);
            this.panelproductos.ResumeLayout(false);
            this.panelproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtresultadobusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelproductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnGuardarcambios;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtresultadobusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbxfiltro;
        private System.Windows.Forms.ComboBox cbxcategoria;
    }
}

