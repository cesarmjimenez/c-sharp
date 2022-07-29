using System;

namespace PilaresPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Perro
            Perro perro = new Perro("Pitbull");
            perro.Nombre = "Scooby";
            perro.Patas = 4;
            perro.Alimento = "Croquetas";
            Console.WriteLine(perro.Nombre + " es un " + perro.Raza);
            perro.Caminar();
            perro.Comer();
            perro.Ladrar();
            Console.WriteLine("");

            //Gato
            Gato gato = new Gato("Cafe", "Grises");
            gato.Nombre = "Misifus";
            gato.Alimento = "Comida de Gatos";
            gato.Patas = 4;
            Console.WriteLine(gato.Nombre + " es un gato de color " + gato.Color + " y ojos color " + gato.ColorOjos);
            gato.Comer();
            gato.Caminar();
            gato.Maullar();
            Console.WriteLine("");

            //Mono
            Mono mono = new Mono("Mono Araña");
            mono.Nombre = "Monki";
            mono.Patas = 2;
            mono.Alimento = "Bananas";
            Console.WriteLine(mono.Nombre + " es un " + mono.Especie);
            mono.Caminar();
            mono.Comer();
            mono.Aullar();
            Console.WriteLine("");

            //Aguila
            Aguila aguila = new Aguila("Aguila Calva");
            aguila.Nombre = "Falco";
            aguila.ColorPlumaje = "Blanco con negro";
            aguila.ColorPico = "Amarillo";
            aguila.Alimento = "Prezas pequeñas";
            Console.WriteLine(aguila.Nombre + " es un " + aguila.Tipo + " de plumaje " + aguila.ColorPlumaje);
            aguila.Comer();
             aguila.VolarAlto(rnd.Next(300, 500));
            Console.WriteLine("");

            //Loro
            Loro loro = new Loro("Guacamayo");
            loro.Nombre = "Polly";
            loro.ColorPlumaje = "Arcoiris";
            loro.ColorPico = "Blanco";
            loro.Alimento = "Semillas";
            Console.WriteLine(loro.Nombre + " es un " + loro.Tipo + " de plumaje " + loro.ColorPlumaje);
            loro.Comer();
            loro.Hablar("Polly Quiere Galleta");
            Console.WriteLine("");

            //Pez Globo
            PezGlobo pezGlobo = new PezGlobo(20);
            pezGlobo.Nombre = "Globito";
            pezGlobo.NumerodeAletas = 2;
            pezGlobo.Especie = "Pez Globo Pigmeo";
            pezGlobo.Alimento = "Peces pequeños";
            Console.WriteLine(pezGlobo.Nombre + "es un " + pezGlobo.Especie);
            pezGlobo.Comer();
            pezGlobo.Nadar(rnd.Next(20, 50));
            pezGlobo.Inflarse(rnd.Next(0, 1));
            Console.WriteLine("");

        }
    }
}