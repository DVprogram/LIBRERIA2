using LIBRERIA_2.DATOS;
using LIBRERIA2.DATOS;
using LIBRERIA2.LOGICA;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Dproductos = LIBRERIA2.DATOS.Dproductos;
using UserControl = System.Windows.Forms.UserControl;

namespace LIBRERIA2.VISTAS
{
    public partial class VERPRODUCTOS : UserControl
    {
        internal object dtresultadosbusqueda;


        public VERPRODUCTOS()
        {
            InitializeComponent();



        }

         public int Idproducto;



        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text;

            // Crear una instancia de la clase Dproductos
            Dproductos dProductos = new Dproductos();

            // Realizar la búsqueda y obtener los resultados en un DataTable
            DataTable dtResultados = dProductos.buscarProductos(textoBusqueda);

            // Asignar el DataTable como origen de datos del DataGridView
            dtresultadobusqueda.DataSource = dtResultados;

        }



        private void VERPRODUCTOS_Load(object sender, EventArgs e)
        {
            //// Crear instancia de la clase Dproductos
            //Dproductos dProductos = new Dproductos();

            //// Obtener los datos de la base de datos en un DataTable
            //DataTable dtDatosProductos = dProductos.Mostrarultimafila();

            //// Asignar el DataTable como origen de datos del DataGridView dtresultadobusqueda
            //dtresultadobusqueda.DataSource = dtDatosProductos;
            Dproductos productos = new Dproductos();
            DataTable dtProductos = productos.MostrarProductos();
            dtresultadobusqueda.DataSource = dtProductos;
            Diseñodt(ref dtresultadobusqueda);
            dtresultadobusqueda.ColumnHeadersDefaultCellStyle.SelectionBackColor = dtresultadobusqueda.ColumnHeadersDefaultCellStyle.BackColor;
            dtresultadobusqueda.ColumnHeadersDefaultCellStyle.SelectionForeColor = dtresultadobusqueda.ColumnHeadersDefaultCellStyle.ForeColor;
            dtresultadobusqueda.AllowUserToAddRows = false;


        }

        private static void Diseñodt(ref DataGridView listado)
        {

            //listado.BackgroundColor = Color.FromArgb(29, 29, 29);
            listado.EnableHeadersVisualStyles = false;
            listado.BorderStyle = BorderStyle.None;
            //listado.CellBorderStyle = DataGridViewCellBorderStyle.None; 
            //listado.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(64, 64, 64);
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Segoe Ui", 14);
            listado.ColumnHeadersDefaultCellStyle = cabecera;

        }

        private void dtresultadobusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtresultadobusqueda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {

            NuevoProducto nuevoprod = new NuevoProducto(); // Crea una instancia del formulario "Form2"
            nuevoprod.VerProductosForm = this;
            nuevoprod.ShowDialog(); // Muestra el formulario

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario "EditarProducto"
            EditarProducto editar = new EditarProducto();

            // Obtener el valor de la celda seleccionada en la columna 0 (ID del producto) y asignarlo a la variable "Idproducto"
            Idproducto = Convert.ToInt32(dtresultadobusqueda.SelectedCells[0].Value.ToString());
            editar.ID.Text = dtresultadobusqueda.SelectedCells[0].Value.ToString();
            // Asignar el valor de la celda seleccionada en la columna 1 (nombre del producto) al TextBox "txtProducto" en el formulario "editar"
            editar.txtProducto.Text = dtresultadobusqueda.SelectedCells[1].Value.ToString();
            editar.txtcantidad.Text = dtresultadobusqueda.SelectedCells[6].Value.ToString();
            editar.txrprecio.Text = dtresultadobusqueda.SelectedCells[2].Value.ToString();
            editar.txtprecioventa.Text = dtresultadobusqueda.SelectedCells[5].Value.ToString();
            editar.cbxmarca.Text = dtresultadobusqueda.SelectedCells[4].Value.ToString();
            editar.cbxcategoria.Text = dtresultadobusqueda.SelectedCells[3].Value.ToString();
            editar.VerProductosForm = this;

            // Mostrar el formulario "editar" como un cuadro de diálogo modal
            editar.ShowDialog();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtresultadobusqueda.SelectedRows.Count > 0)
            {
                // Obtener el IdProducto del producto seleccionado en el DataGridView
                int idProducto = Convert.ToInt32(dtresultadobusqueda.SelectedRows[0].Cells["IdProducto"].Value);

                // Mostrar un mensaje de confirmación al usuario
                DialogResult resultado = MessageBox.Show("¿Desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Intentar eliminar el producto
                    Dproductos productos = new Dproductos();
                    productos.eliminarproducto(idProducto);
                    MessageBox.Show("Eliminado correctamente", "Felicidades!");
                    mostrardt();
                }
   

            }

        }
        public  void mostrardt()
        {
            Dproductos productos = new Dproductos();
            DataTable dtProductos = productos.MostrarProductos();
            dtresultadobusqueda.DataSource = dtProductos;
        }
    }

       
}
