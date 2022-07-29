public class Aguila: Aves
{
    public string Tipo { get; set; }

    public Aguila(string tipo)
    {
        Tipo = tipo;
    }

    public void VolarAlto(int altura)
    {
        Vuelo(altura);
        
    }

    private void Vuelo(int altura)
    {
        Console.WriteLine("La altura de vuelo es de " + altura + " metros.");
    }
}