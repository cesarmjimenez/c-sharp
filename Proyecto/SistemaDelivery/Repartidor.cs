public class Repartidor: Persona
{
    public string CodigoRepartidor { get; set; }
    public string Calificacion { get; set; }

    public Repartidor(string codigo, string nombre, string codigoRepartidor, string calificacion)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoRepartidor = codigoRepartidor;
        Calificacion = calificacion;
    }
}