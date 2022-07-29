public class Loro: Aves
{
    public string Tipo { get; set; }

    public Loro(string tipo)
    {
        Tipo = tipo;
    }

    public void Hablar(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}