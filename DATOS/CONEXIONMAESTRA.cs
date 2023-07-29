using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LIBRERIA2.LOGICA;
using System.Windows.Forms;
using System.Data;
using LIBRERIA_2.DATOS;

namespace LIBRERIA2.DATOS
{
    internal class CONEXIONMAESTRA
    {
        public static SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-ROAJM23O\\SQLEXPRESS; Initial Catalog=Libreria2; Integrated Security=true");

        public static void abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public static void cerrar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }

    class Dproductos
    {
        private SqlCommand cmd = new SqlCommand();
        private int idproducto;

        public bool insertar(Lproductos dtproductos)
        {
            try
            {
                CONEXIONMAESTRA.abrir(); // Conexión abierta

                cmd = new SqlCommand("insertarproducto", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Producto", dtproductos.Producto);
                cmd.Parameters.AddWithValue("@Precio", dtproductos.Precio);
                cmd.Parameters.AddWithValue("@Categoria", dtproductos.Categoria);
                cmd.Parameters.AddWithValue("Marca", dtproductos.Marca);
                cmd.Parameters.AddWithValue("Precioventa", dtproductos.Precioventa);
                cmd.Parameters.AddWithValue("Cantidad", dtproductos.Cantidad);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true; // Éxito en la inserción
                }
                else
                {
                    return false; // Error en la inserción
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Error en la inserción
            }
            finally
            {
                CONEXIONMAESTRA.cerrar(); // Conexión cerrada en el bloque finally
            }
        }

        public DataTable buscarProductos(string buscador)
        {
            DataTable dt = new DataTable();
            try
            {
                CONEXIONMAESTRA.abrir();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE Producto LIKE @Buscador + '%' OR Precio LIKE @Buscador + '%' OR Precioventa LIKE @Buscador + '%' OR Cantidad LIKE @Buscador + '%' OR Marca LIKE @Buscador + '%' OR Categoria LIKE @Buscador + '%'", CONEXIONMAESTRA.conexion);
                cmd.Parameters.AddWithValue("@Buscador", buscador);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
            return dt;
        }



        public bool editarproductos(Lproductos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarproductos", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdProducto", parametros.Idproducto);
                cmd.Parameters.AddWithValue("@Producto", parametros.Producto);
                cmd.Parameters.AddWithValue("@Precio", parametros.Precio);
                cmd.Parameters.AddWithValue("@Categoria", parametros.Categoria);
                cmd.Parameters.AddWithValue("@Marca", parametros.Marca);
                cmd.Parameters.AddWithValue("@Precioventa", parametros.Precioventa);
                cmd.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool eliminarproducto(int Idproducto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminarproducto", CONEXIONMAESTRA.conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", Idproducto);

                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public DataTable MostrarProductos()
        {
            DataTable dtResultados = new DataTable();

            try
            {
                CONEXIONMAESTRA.abrir(); // Abre la conexión a la base de datos

                SqlDataAdapter da = new SqlDataAdapter("mostrarProductos", CONEXIONMAESTRA.conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dtResultados); // Llena el DataTable con los datos obtenidos del procedimiento almacenado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar(); // Cierra la conexión a la base de datos en caso de éxito o error
            }

            return dtResultados;
        }



    }
}
