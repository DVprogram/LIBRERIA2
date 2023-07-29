using LIBRERIA2.LOGICA;
using LIBRERIA2.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA2.VISTAS
{
    public partial class NuevoProducto : Form
    {
        public VERPRODUCTOS VerProductosForm { get; set; }
        public NuevoProducto()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingrese Producto", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Ingrese Cantidad", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txrprecio.Text))
            {
                MessageBox.Show("Ingrese Precio de compra", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtprecioventa.Text))
            {
                MessageBox.Show("Ingrese Precio de venta", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxmarca.Text))
            {
                MessageBox.Show("Ingrese Marca", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxcategoria.Text))
            {
                MessageBox.Show("Ingrese Categoría", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            

            insertar_productos();

          
            // Limpiar los TextBox
            txtProducto.Clear();
            txtprecioventa.Clear();
            txrprecio.Clear();
            txtcantidad.Clear();


            // Establecer los ComboBox en blanco
            cbxmarca.Text = "";
            cbxcategoria.Text = "";





        }

        private void insertar_productos()
        {
            Lproductos dt = new Lproductos();
            Dproductos funcion = new Dproductos();
            dt.Producto = txtProducto.Text;
            dt.Precio = float.Parse(txrprecio.Text);
            dt.Categoria = cbxcategoria.Text;
            dt.Marca=cbxmarca.Text;
            dt.Precioventa=float.Parse(txtprecioventa.Text);
            dt.Cantidad=int.Parse(txtcantidad.Text);


            if (funcion.insertar(dt))
            {
                MessageBox.Show("Producto registrado", "Felicidades!");
                // La inserción del producto fue exitosa
                // Agrega aquí la lógica adicional que deseas realizar en caso de éxito
                this.Close();
                this.VerProductosForm.mostrardt();
            }


        }
        public void mostrardt()
        {

        }
       



        private void cbxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelproductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
