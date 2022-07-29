public class Perro: Mamiferos
{
    public string Raza { get; set; }

    public Perro(string raza)
    {
        Raza = raza;
    }

    public void Ladrar()
    {
        Console.WriteLine("Woof");
    }
}