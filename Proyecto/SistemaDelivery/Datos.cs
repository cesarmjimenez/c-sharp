using System;
using System.Collections.Generic;
public class Datos
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Repartidor> ListadeRepartidores { get; set; }
    public List<Pedidos> ListaPedidos { get; set; }

    public Datos()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeRepartidores = new List<Repartidor>();
        cargarRepartidores();

        ListaPedidos = new List<Pedidos>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Libra de carne", 250);
        ListadeProductos.Add(p1);
        Producto p2 = new Producto(2, "Libra de arroz", 150);
        ListadeProductos.Add(p2);
        Producto p3 = new Producto(3, "Libra de maiz", 100);
        ListadeProductos.Add(p3);
        Producto p4 = new Producto(4, "Libra de verduras", 75);
        ListadeProductos.Add(p4);
        Producto p5 = new Producto(5, "Libra de frutas", 80);
        ListadeProductos.Add(p5);
        Producto p6 = new Producto(6, "Orden de alitas", 120);
        ListadeProductos.Add(p6);
        Producto p7 = new Producto(7, "Orden de pollo Frito", 140);
        ListadeProductos.Add(p7);
        Producto p8 = new Producto(8, "Orden de hamburguesa", 130);
        ListadeProductos.Add(p8);
        Producto p9 = new Producto(9, "Caja de pizza", 120);
        ListadeProductos.Add(p9);
        Producto p10 = new Producto(10, "Orden carne asada", 180);
        ListadeProductos.Add(p10);
        Producto p11 = new Producto(11, "Refresco 3 litros", 80);
        ListadeProductos.Add(p11);
        Producto p12 = new Producto(12, "Sixpack de cerveza", 150);
        ListadeProductos.Add(p12);
        Producto p13 = new Producto(13, "Sixpack refresco en lata", 140);
        ListadeProductos.Add(p13);
        Producto p14 = new Producto(14, "Sixcpack refresco 3 litros", 240);
        ListadeProductos.Add(p14);
        Producto p15 = new Producto(15, "Reposteria", 170);
        ListadeProductos.Add(p15);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente("01", "Cesar Muñoz", "99221144", 120);
        ListadeClientes.Add(c1);
        Cliente c2 = new Cliente("02", "Nahomy Guevara", "32567786", 50);
        ListadeClientes.Add(c2);
        Cliente c3 = new Cliente("03", "Derin Orellana", "34457821", 250);
        ListadeClientes.Add(c3);
        Cliente c4 = new Cliente("04", "Marcos Lopez", "93574312", 30);
        ListadeClientes.Add(c4);
        Cliente c5 = new Cliente("05", "Pedro Molina", "99331457", 400);
        ListadeClientes.Add(c5);
    }

    private void cargarRepartidores()
    {
        Repartidor r1 = new Repartidor("01", "Jose Martinez", "R001", "Bueno");
        ListadeRepartidores.Add(r1);
        Repartidor r2 = new Repartidor("02", "Lucas Perez", "R002", "Muy bueno");
        ListadeRepartidores.Add(r2);
        Repartidor r3 = new Repartidor("03", "Angel Hernandez", "R003", "Decente");
        ListadeRepartidores.Add(r3);
        Repartidor r4 = new Repartidor("04", "Luis Posadas", "R004", "Bueno");
        ListadeRepartidores.Add(r4);
        Repartidor r5 = new Repartidor("05", "Hensel Jimenez", "R005", "Muy bueno");
        ListadeRepartidores.Add(r5);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        Console.WriteLine("Codigo | Nombre | Telefono | Distancia");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono + " | " + cliente.Distancia);
        }

        Console.ReadLine();
    }

    public void ListarRepartidores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");
        Console.WriteLine("Codigo | Nombre | Codigo Repartidor");
        Console.WriteLine("");
        
        foreach (var Repartidor in ListadeRepartidores)
        {
            Console.WriteLine(Repartidor.Codigo + " | " + Repartidor.Nombre + " | " + Repartidor.CodigoRepartidor);
        }

        Console.ReadLine();
    }

    public void CrearPedido()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine()!;

        Cliente cliente = ListadeClientes.Find(c => c.Codigo == codigoCliente)!;        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del repartidor: ");
        string codigoRepartidor = Console.ReadLine()!;

        Repartidor repartidor = ListadeRepartidores.Find(r => r.Codigo == codigoRepartidor)!;
        if (repartidor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + repartidor.Nombre);
            Console.WriteLine("");
            Console.ReadLine();
        }

        int nuevoCodigo = ListaPedidos.Count + 1;

        Pedidos nuevoPedido = new Pedidos(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, repartidor);
        ListaPedidos.Add(nuevoPedido);

        while(true)
        {
            ListarProductos();
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine()!;
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto)!;        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevoPedido.AgregarProducto(producto, cliente);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine()!;
            if (continuar!.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Total de la orden es de: " + nuevoPedido.Total);
        Console.ReadLine();
    }

    public void ListarPedidos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Pedidos");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha | SubTotal | Tarifa | Total");
        Console.WriteLine("Cliente | Repartidor");
        Console.WriteLine("======================");
        Console.WriteLine("");  

        foreach (var Pedido in ListaPedidos)
        {
            Console.WriteLine(Pedido.Codigo + " | " + Pedido.Fecha + " | " + Pedido.SubTotal + " | " + Pedido.Tarifa + " | " + Pedido.Total);
            Console.WriteLine(Pedido.Cliente.Nombre + " | " + Pedido.Repartidor.Nombre);
            
            foreach (var Detalle in Pedido.ListaDetalles)
            {
                Console.WriteLine("     " + Detalle.Producto.Descripcion + " | " + Detalle.Cantidad + " | " + Detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}