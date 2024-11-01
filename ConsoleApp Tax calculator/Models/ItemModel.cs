using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tax_calculator.Models
{
    public class ItemModel
    {
        private ProductoModel producto;
        private int cantidad;

        public ItemModel(ProductoModel producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public int Cantidad
        {
            get { return cantidad; } 
            set { cantidad = value; }
        }
     
        public ProductoModel Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public override string ToString()
        {          
            Console.WriteLine(producto);
            Console.WriteLine(cantidad);

            return ToString();
        }
    }
}

