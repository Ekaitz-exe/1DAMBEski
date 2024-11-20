internal class Program
{
    static void Array()
    {
        Random semilla = new Random();
        int [] Array  = new int[10];
        for(int i=0;Array.Length > i;i++)
        {
            Array[i]=semilla.Next(1, 20); 
        }
        int numeroMaximo = Array.Max();
        int posicionArray = System.Array.IndexOf(Array, numeroMaximo);
        Console.WriteLine($"El numero máximo es {numeroMaximo}, el cual se encuentra en la posición {posicionArray}");
    }
    private static void Main(string[] args)
    {
        Array();
    }
}