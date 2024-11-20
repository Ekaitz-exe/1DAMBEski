using System.Text;

internal class Program
{
    static void Mostrar(char [] array)
    {
        foreach (char c in array)
        {
            Console.WriteLine(c + " ");

        }
    }
    static void Array()
    {
        Random random = new Random();
        char[] array = new char[10];
        for (int i = 0; i < array.Length; i++)
        {
            char caracteraleatorio;
            do
            {
                // Rango de ASCII
                int ascii = random.Next(65, 123);
                caracteraleatorio = (char)ascii;
            } while (!char.IsLetter(caracteraleatorio));
            // Con el while de arriba nos aseguramos que sea una letra
            array[i] = caracteraleatorio;
        }
        Mostrar(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (char.IsLower(array[i]))
            {
                char letraAMayus = char.ToUpper(array[i]);
                array[i] = letraAMayus;

            }
            else
            {
                char letraAMinus = char.ToLower(array[i]);
                array[i] = letraAMinus;
            }
        }
    }
    private static void Main(char[] array)
    {
        Array();
        Mostrar(array);
    }
}