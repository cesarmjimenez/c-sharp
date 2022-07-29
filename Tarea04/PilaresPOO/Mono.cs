public class Mono: Mamiferos
{
    public string Especie { get; set; }

    public Mono(string especie)
    {
        Especie = especie;
    }

    public void Aullar()
    {
        Console.WriteLine("Uh uh ah ah");
    }
}