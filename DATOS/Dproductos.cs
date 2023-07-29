using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LIBRERIA2.DATOS;
using LIBRERIA2.LOGICA;

namespace LIBRERIA_2.DATOS
{
    class Dproductos
    {
        private SqlCommand cmd = new SqlCommand();
        private int idproducto;
        private ComboBox cbxfiltro;

        public bool insertar(Lproductos dtproductos)
        {
            try
            {
                CONEXIONMAESTRA.abrir();

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
                    return true;
                }
                else
                {
                    return false;
                }
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

        public static List<string> ObtenerNombresCategorias()
        {
            List<string> nombresCategorias = new List<string>();

            try
            {
                CONEXIONMAESTRA.abrir();

                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Categoria FROM Productos", CONEXIONMAESTRA.conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombreCategoria = reader["Categoria"].ToString();
                    nombresCategorias.Add(nombreCategoria);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

            // Eliminar el primer elemento en blanco si existe
            if (nombresCategorias.Count > 0 && string.IsNullOrWhiteSpace(nombresCategorias[0]))
            {
                nombresCategorias.RemoveAt(0);
            }

            return nombresCategorias;
        }









    }
}
