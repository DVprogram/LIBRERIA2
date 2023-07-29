using LIBRERIA_2.DATOS;
using LIBRERIA2.LOGICA;
using LIBRERIA2.VISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace LIBRERIA2
{
    public partial class VISTA1 : Form
    {
        public VISTA1()
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            panelproductos.Visible = true;

            // Limpiar los TextBox
            txtProducto.Clear();
            txtprecio.Clear();
            
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

            // Agregar el nuevo valor al ComboBox cbxfiltro
            string nuevaCategoria = cbxcategoria.Text.Trim();
            if (!cbxfiltro.Items.Contains(nuevaCategoria))
            {
                cbxfiltro.Items.Add(nuevaCategoria);
            }

            // Agregar el nuevo valor al ComboBox cbxcategoria si no existe
            if (!cbxcategoria.Items.Contains(nuevaCategoria))
            {
                cbxcategoria.Items.Add(nuevaCategoria);
            }

            // Limpiar los TextBox
            txtProducto.Clear();
            txtprecio.Clear();
            // Establecer el combobox cbxcategoria en blanco
            cbxcategoria.Text = "";

            


        }
        private void insertar_productos()
        {
            Lproductos dt = new Lproductos();
            Dproductos funcion = new Dproductos();
            dt.Producto = txtProducto.Text;
            dt.Precio = float.Parse(txtprecio.Text);
            dt.Categoria=cbxcategoria.Text;
           

            if (funcion.insertar(dt))
            {
                MessageBox.Show("Producto registrado", "Felicidades!");
                // La inserción del producto fue exitosa
                // Agrega aquí la lógica adicional que deseas realizar en caso de éxito
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProducto.Text))
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                txtProducto.Text = textInfo.ToTitleCase(txtProducto.Text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string producto = txtBuscar.Text;

            Dproductos datosProductos = new Dproductos();
            DataTable dtResultados = datosProductos.buscarProductos(producto);

            dtresultadobusqueda.DataSource = dtResultados;
        }


        private void cbxfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cbxfiltro.SelectedItem?.ToString(); // Obtener la categoría seleccionada

            if (!string.IsNullOrWhiteSpace(categoria))
            {
                // Realizar la búsqueda de productos por categoría y mostrar los resultados
                Dproductos datosProductos = new Dproductos();
                DataTable dtResultados = datosProductos.buscarProductos(categoria);
                dtresultadobusqueda.DataSource = dtResultados;
            }
        }


        private void cbxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cbxcategoria.SelectedItem.ToString(); // Obtener la categoría seleccionada
        }

        private void cbxcategoria_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxcategoria.Text))
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                cbxcategoria.Text = textInfo.ToTitleCase(cbxcategoria.Text);
            }
        }

        private void VISTA1_Load(object sender, EventArgs e)
        {
            // Obtener los nombres de las categorías
            List<string> nombresCategorias = Dproductos.ObtenerNombresCategorias();

            // Cargar los nombres de las categorías en los ComboBox
            cbxfiltro.Items.AddRange(nombresCategorias.ToArray());
            cbxcategoria.Items.AddRange(nombresCategorias.ToArray());
        }

       
    }
}