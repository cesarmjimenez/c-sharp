public class PezGlobo: Peces
{
    public int Tamaño { get; set; }

    public PezGlobo(int tamaño)
    {
        Tamaño = tamaño;
    }

    public void Inflarse(int amenaza)
    {
        if (amenaza == 0)
        {
            Console.WriteLine("El pez globo se inflo");
        } else
        {
            Console.WriteLine("El pez globo no se inflo");
        }
    }
}