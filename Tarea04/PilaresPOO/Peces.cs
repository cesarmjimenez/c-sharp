public class Peces: Animal
{
    public string Especie { get; set; }
    public int NumerodeAletas { get; set; }

    public void Nadar(int velocidadNado)
    {
        Nado(velocidadNado);
        
    }

    private void Nado(int velocidadNado)
    {
        Console.WriteLine("El pez nada a una velocidad de " + velocidadNado);
    }
}