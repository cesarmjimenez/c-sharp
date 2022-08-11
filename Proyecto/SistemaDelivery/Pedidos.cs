using System;
using System.Collections.Generic;

public class Pedidos
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodePedido { get; set; }
    public Cliente Cliente { get; set; }
    public Repartidor Repartidor { get; set; }
    public List<DetallesPedidos> ListaDetalles { get; set; }
    public double Total { get; set; }
    public double SubTotal { get; set; }
    public double Tarifa { get; set; }

    public Pedidos(int codigo, DateTime fecha, string numeroPedido, Cliente cliente, Repartidor repartidor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodePedido = numeroPedido;
        Cliente = cliente;
        Repartidor = repartidor;
        ListaDetalles = new List<DetallesPedidos>();
    }

    public void AgregarProducto(Producto producto, Cliente cliente)
    {
        int nuevoCodigo = ListaDetalles.Count + 1;
        int cantidad = 1;

        DetallesPedidos o = new DetallesPedidos(nuevoCodigo, 1, producto);
        ListaDetalles.Add(o);

        SubTotal += cantidad * producto.Precio;

        if (cliente.Distancia <= 30)
        {
            Tarifa = SubTotal * 0.05;
        } else if (cliente.Distancia > 31 && cliente.Distancia <= 50)
        {
            Tarifa = SubTotal * 0.1;
        } else if (cliente.Distancia > 51 && cliente.Distancia <= 150)
        {
            Tarifa = SubTotal * 0.15;
        } else if (cliente.Distancia > 151 && cliente.Distancia <= 250)
        {
            Tarifa = SubTotal * 0.25;
        } else if (cliente.Distancia > 251 && cliente.Distancia <= 500)
        {
            Tarifa = SubTotal * 0.3;
        }

        Total = SubTotal + Tarifa;

    }
}