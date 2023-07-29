using LIBRERIA2.DATOS;
using LIBRERIA2.LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIA2.VISTAS;

namespace LIBRERIA2.VISTAS
{
    public partial class EditarProducto : Form
    {
        public VERPRODUCTOS VerProductosForm { get; set; }
        public EditarProducto()
        {
            InitializeComponent();
        }
        
       

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

        private void EditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void paneleditar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnguardareditado_Click(object sender, EventArgs e)
        {
            EDITARPRODUCTO();
            

        }

        private void EDITARPRODUCTO()
        {
            VERPRODUCTOS ver = new VERPRODUCTOS();
            int idprodselect = ver.Idproducto;
            Lproductos parametros = new Lproductos();
            Dproductos funcion = new Dproductos();
            parametros.Idproducto = idprodselect;
            parametros.Idproducto = int.Parse(ID.Text);
            parametros.Producto = txtProducto.Text;
            parametros.Cantidad = int.Parse(txtcantidad.Text);
            parametros.Precio = (float)Convert.ToDouble(txrprecio.Text);
            parametros.Precioventa = (float)Convert.ToDouble(txtprecioventa.Text);
            parametros.Marca = cbxmarca.Text;
            parametros.Categoria = cbxcategoria.Text;
            if (funcion.editarproductos(parametros) == true)
            {
                MessageBox.Show("Producto Editado correctamente", "Felicidades!");
                // La inserción del producto fue exitosa
                // Agrega aquí la lógica adicional que deseas realizar en caso de éxito
                // Llamar al método mostrardt desde la instancia creada

                this.Close();
                this.VerProductosForm.mostrardt();
                

            }

            




        }
        
        





        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
