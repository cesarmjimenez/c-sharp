public class Gato: Mamiferos
{
    public string Color { get; set; }
    public string ColorOjos { get; set; }

    public Gato(string color, string colorOjos)
    {
        Color = color;
        ColorOjos = colorOjos;
    }

    public void Maullar()
    {
        Console.WriteLine("Miauu");
    }
}