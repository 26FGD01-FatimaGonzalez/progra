internal class Program
{
    private static void Main(string[] args)
    {
        int pesoManzana = 0;
        int cantidadManzanas = 0;
        int cantidad = 0;
        int peso = 0;

        while (peso < 1000)
        {
            Console.WriteLine("Ingrese el peso de la manzana: ");
            pesoManzana = int.Parse(Console.ReadLine());

            if (pesoManzana >= 180)
            {

                peso += pesoManzana;
                Console.WriteLine("Cantidad de manzanas: " + peso + "Gramos");
                cantidadManzanas++;


            }
            else
            {
                Console.WriteLine("El peso de la manzana no puede ser mayor a 1000 gramos.");
            }
        }
        Console.WriteLine("Ya alcanzo o supero 1 kilo de manzanas");
        Console.WriteLine("Cantidad total de manzanas: " + cantidadManzanas);
        
    }
}