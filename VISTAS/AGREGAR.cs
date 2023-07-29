using LIBRERIA2.DATOS;
using LIBRERIA2.LOGICA;
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
    public partial class AGREGAR : UserControl
    {
        public AGREGAR()
        {
            InitializeComponent();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número, un punto decimal o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ignorar la tecla presionada si ya hay un punto decimal
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingrese Producto", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("Ingrese Precio", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtprecio.Clear();
            // Redirigir al control de usuario "VERPRODUCTO"
            VERPRODUCTOS verProductoControl = new VERPRODUCTOS();
            // Aquí puedes realizar cualquier configuración adicional o pasar datos al control de usuario "VERPRODUCTO"

            // Agregar el control de usuario "VERPRODUCTO" al formulario principal
            this.Parent.Controls.Add(verProductoControl);
            // Opcionalmente, puedes remover el control de usuario actual (AGREGAR)
            this.Parent.Controls.Remove(this);


            




        }

        private void insertar_productos()
        {
            Lproductos dt = new Lproductos();
            Dproductos funcion = new Dproductos();
            dt.Producto = txtProducto.Text;
            dt.Precio = float.Parse(txtprecio.Text);
            dt.Categoria = cbxcategoria.Text;


            if (funcion.insertar(dt))
            {
                MessageBox.Show("Producto registrado", "Felicidades!");
                // La inserción del producto fue exitosa
                // Agrega aquí la lógica adicional que deseas realizar en caso de éxito
            }
        }
      


        private void dtresultadobusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
