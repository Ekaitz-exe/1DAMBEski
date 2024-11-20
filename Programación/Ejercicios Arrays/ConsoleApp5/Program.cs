internal class Program
{
    static void Arrays()
    {
        Random semilla = new Random();
        int[] Array = new int[10];
        for (int i = 0; Array.Length > i; i++)
        {
            Array[i] = semilla.Next(1, 10);
            Console.WriteLine("----------Todos los numeros-------------");
            Console.WriteLine(Array[i]);
            Console.WriteLine("----------Todos los numeros-------------");
            Console.WriteLine("----------Numeros Pares-------------");
            if (Array[i] - Array[i] / 2 * 2 == 0)
            {
                Console.WriteLine(Array[i]);
                Console.WriteLine($"Posicion Numero {i}");
            }
            else
            {
                Console.WriteLine($"Posicion Numero {i} No es Par");
            }
            Console.WriteLine("----------Numeros pares-------------");
        }

    }
    private static void Main(string[] args)
    {
        Arrays();
    }
}