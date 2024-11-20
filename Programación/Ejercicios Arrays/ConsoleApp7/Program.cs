internal class Program
{
    static void Arrays()
    {
        int[] v = new int[10];
        
        int p=0;
        int i=0;
        Random semilla = new Random();
        for (int j=0;v.Length > j; j++)
        {
        v[j]= semilla.Next(1, 20);
        // Con el siguiente if preguntamos a ver si es par
        if (v[j] - v[j] / 2 * 2 == 0)
        {
            p++;
        }
        // Con este miramos si es impar
        else if(v[j] - v[j] / 2 * 2 != 0)
        {
            i++;
        }
        }
        Console.WriteLine($"Hay {p} numeros que son pares");
        Console.WriteLine($"Hay {i} numeros que son impares");
    }
    private static void Main(string[] args)
    {
        Arrays();
    }
}