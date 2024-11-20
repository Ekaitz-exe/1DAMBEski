internal class Program
{
    static void SumaArrays()
    {
        Random random = new Random();
        int sumaDeArrays = 0;
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 20);
            sumaDeArrays += array[i];
            Console.WriteLine(array[i]);
        }
        Console.WriteLine($"{sumaDeArrays} es la suma de todos los elementos aleatorios del array");


    }
    private static void Main(string[] args)
    {
        SumaArrays();
    }
}