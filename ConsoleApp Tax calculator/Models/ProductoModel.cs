using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tax_calculator.Models
{
    public class ProductoModel
    {
        private string nombre;
        private float precio;

        public ProductoModel(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get{ return nombre; }
            set{ nombre = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public override string ToString()
        {

            Console.WriteLine(nombre);
            Console.WriteLine(precio);
           
            return ToString();
        }
    }
}
