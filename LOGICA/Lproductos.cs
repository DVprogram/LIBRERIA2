using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBRERIA2.LOGICA;

namespace LIBRERIA2.LOGICA
{
    public class Lproductos
    {
        private int idproducto;
        private string producto;
        private float precio;
        private string categoria;
        private string marca;
        private float precioventa;
        private int cantidad;

        public int Idproducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public float Precioventa
        {
            get { return precioventa; }
            set { precioventa = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Lproductos()
        {

        }
        public Lproductos(int idproducto, string producto, float precio,string categoria, string marca, float precioventa, int cantidad)
        {
            this.idproducto = idproducto;
            this.producto = producto;
            this.precio = precio;
            this.categoria = categoria;
            this.marca = marca;
            this.precioventa = precioventa;
            this.cantidad = cantidad;
            
        }
    }
}
