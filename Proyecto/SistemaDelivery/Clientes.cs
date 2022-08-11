public class Cliente: Persona
{
    public int Distancia { get; set; }
    public Cliente(string codigo, string nombre, string telefono, int distancia)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Distancia = distancia;
    }
}