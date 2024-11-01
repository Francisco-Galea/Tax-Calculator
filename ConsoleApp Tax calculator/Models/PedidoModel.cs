using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tax_calculator.Models
{
   public class PedidoModel
    {
        private List<ItemModel> items;
        private CalculadoraImpuesto calcularImpuesto;
        private string pais;
        private string estado;
        private string ciudad;

        public PedidoModel(List<ItemModel> items, string pais, string estado, string ciudad)
        {
            this.items = items;
            this.pais = pais;
            this.estado = estado;
            this.ciudad = ciudad;
            this.calcularImpuesto = new CalculadoraImpuesto();
        }

        public List<ItemModel> Items
        {
            get { return items; }
            set { items = value; }
        }

        public CalculadoraImpuesto CalcularImpuesto
        {
            get { return calcularImpuesto; }
            set { calcularImpuesto = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public float calcularPrecioFinal()
        {
            float precioFinal = 0;
            float subTotal = 0;

            foreach (var producto in items)
            {
                subTotal += (producto.Cantidad * producto.Producto.Precio);              
            }
            precioFinal = subTotal;
            precioFinal += precioFinal *CalcularImpuesto.getTaxRate(pais);

            return precioFinal;
        }

        public override string ToString()
        {
            foreach (ItemModel item in Items)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(pais);
                Console.WriteLine(estado);
                Console.WriteLine(ciudad);
                Console.WriteLine(calcularPrecioFinal());
            }

            return ToString();
        }
    }
}
