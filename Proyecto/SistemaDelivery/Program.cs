using System;

namespace SistemaDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos = new Datos();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("BIENVENIDO AL SISTEMA DE DELIVERY");
                Console.WriteLine("=================================");
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1 - Crear Pedido");
                Console.WriteLine("2 - Lista de Clientes");
                Console.WriteLine("3 - Lista de Repartidores");
                Console.WriteLine("4 - Lista de Pedidos");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        datos.CrearPedido();
                        break;
                    case "2":
                        datos.ListarClientes();
                        break;
                    case "3":
                        datos.ListarRepartidores();
                        break;      
                    case "4":
                        datos.ListarPedidos();
                        break;                                          
                    case "0":
                        
                        break;                                          
                    default:
                        Console.WriteLine("Seleccione una opcion valida"); Console.ReadLine();
                        break;
                }

                if (opcion == "0") {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}