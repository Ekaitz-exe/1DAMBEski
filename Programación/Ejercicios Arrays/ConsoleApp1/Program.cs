internal class Program
{
    static int PedirDatos()
    {
        Console.WriteLine("Dame un numero: ");
        int n = int.Parse(Console.ReadLine());
        return n;
    }
    static void ArraysYRandom()
    {
        int n = PedirDatos();
        // Hacemos la semilla de los numeros aleatorios
        Random semilla = new Random();
        // Int [] nombredelarray= new formato[Incializador de array (numero de cosas dentro del array)]
        int [] arraysInt = new int[n];
        // Bucle de Numeros Aleatorios en base a la longitud del array (n longitud)
        for (int i=0; i < arraysInt.Length;i++)
        {
            // Aqui rellenamos arraysInt[] con numeros aleatorios
           arraysInt[i]=semilla.Next(1 ,20);
           Console.WriteLine(arraysInt[i]); 
        }
  
    }

    private static void Main(string[] args)
    {
        // Solamente damos un metodo ya que el otro no podemos ponerlo porque sino nos pide dos veces el numero
        ArraysYRandom();
    }
}
