using System;
using System.Collections.Generic;
public class Orden
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumeroDeOrden { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }

    public Orden(int codigo, DateTime fecha, string numeroDeOrden, Cliente cliente, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumeroDeOrden = numeroDeOrden;
        Cliente = cliente;
        Vendedor = vendedor;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }

    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaOrdenDetalle.Count + 1;
        OrdenDetalle o = new OrdenDetalle(nuevoCodigo, 1, 1, producto);
        ListaOrdenDetalle.Add(o);
    }
}