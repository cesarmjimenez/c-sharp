public class Mamiferos : Animal
{
    public int Patas { get; set; }
    

    public void Caminar()
    {
        Console.WriteLine(Nombre + " Camina en " + Patas + " patas");
    }
}