using ConsoleApp_Tax_calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tax_calculator.Static
{
    public static class ClaseEstatica
    {
        public static List<PedidoModel> pedidos = new List<PedidoModel>();
        public static List<ProductoModel> productos = new List<ProductoModel>();
        public static List<ItemModel> items = new List<ItemModel>();

        public static void iniciar()
        {
            CrearProductos();
            crearPedido(items);
            mostrarPedidos();
        }

        public static void CrearProductos()
        {
            productos.Add(new ProductoModel("Milanesa",500f));
            productos.Add(new ProductoModel("Empanadas", 300f));
            productos.Add(new ProductoModel("Pizza", 450f));
            productos.Add(new ProductoModel("Asado", 700f));
            productos.Add(new ProductoModel("Ensalada", 250f));
            productos.Add(new ProductoModel("Hamburguesa", 350f));
            productos.Add(new ProductoModel("Sushi", 600f));
            productos.Add(new ProductoModel("Tacos", 280f));
            productos.Add(new ProductoModel("Paella", 800f));
            productos.Add(new ProductoModel("Lasagna", 400f));
        }

        public static void crearPedido(List<ItemModel> items)
        {
            pedidos.Add(
                new PedidoModel(new List<ItemModel>() 
                { 

                    new ItemModel(productos[0], 2) ,
                    new ItemModel(productos[5], 3) ,
                    new ItemModel(productos[2], 1) ,
                    new ItemModel(productos[7], 5)

                },"Argentina","Buenos Aires","Miramar"));

            pedidos.Add(
                new PedidoModel(new List<ItemModel>()
                {

                    new ItemModel(productos[0], 2) ,
                    new ItemModel(productos[5], 3) ,
                    new ItemModel(productos[2], 1) ,
                    new ItemModel(productos[7], 5)

                }, "Uruguay", "Montevideo", "Montevideo"));

            pedidos.Add(
                new PedidoModel(new List<ItemModel>()
                {

                    new ItemModel(productos[3], 1) ,
                    new ItemModel(productos[8], 5) ,
                    new ItemModel(productos[1], 3) ,
                    new ItemModel(productos[7], 10)

                }, "China", "Taiwan", "Taipei"));

            pedidos.Add(
                new PedidoModel(new List<ItemModel>()
                {

                    new ItemModel(productos[3], 1) ,
                    new ItemModel(productos[8], 5) ,
                    new ItemModel(productos[1], 3) ,
                    new ItemModel(productos[7], 10)

                }, "España", "Madrid", "Madrid"));

            pedidos.Add(
                new PedidoModel(new List<ItemModel>()
                {

                    new ItemModel(productos[0], 1) ,
                    new ItemModel(productos[1], 5) ,
                    new ItemModel(productos[2], 3) ,
                    new ItemModel(productos[3], 10)

                }, "Estados Unidos", "Texas", "Houston"));
        }

        public static void mostrarPedidos()
        {
            int numPedido = 1;
            Console.WriteLine("Lista de Pedidos:");
            foreach (PedidoModel pedido in ClaseEstatica.pedidos)
            {
                Console.WriteLine();
                Console.WriteLine($"Pedido numero: {numPedido}");
                Console.WriteLine($"País: {pedido.Pais}, Estado: {pedido.Estado}, Ciudad: {pedido.Ciudad}");
                foreach (ItemModel item in pedido.Items)
                {
                    Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Precio unitario: {item.Producto.Precio}");
                }
                Console.WriteLine($"Precio total del pedido: {pedido.calcularPrecioFinal()}");
                numPedido++;
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------");
                

            }
        }

    }
}
