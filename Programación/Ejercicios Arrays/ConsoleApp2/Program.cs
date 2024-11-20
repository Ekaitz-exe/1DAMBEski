internal class Program
{
    static void Arrays()
    {
        Random semilla = new Random();
        double [] arrayDouble = new double[10];        
        for (int i=0; i < arrayDouble.Length;i++)
        {
            // Aqui rellenamos arraysInt[] con numeros aleatorios
            arrayDouble[i]=semilla.Next(0, 100);
            Console.WriteLine(arrayDouble[i]);
        }
        for (int i=0; i < arrayDouble.Length;i++)
        {
        if (arrayDouble[i] %4 == 0d)
        {
            Console.WriteLine("Es multiplo de 4.");
        }
        else if (arrayDouble[i] %4 != 0)
        {
            Console.WriteLine("No es multiplo de 4.");
        }
        }

    }
    private static void Main(string[] args)
    {
        Arrays();
    }
}