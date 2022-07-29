 public class Animal
    {
        public string Nombre { get; set; }
        public string Alimento { get; set; }

        public Animal()
        {
            Alimento = "No definido";
        }
        public void Comer()
        {
            Console.WriteLine(Nombre + " Come " + Alimento);
        }
    }   
