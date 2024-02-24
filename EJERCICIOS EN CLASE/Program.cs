class Program
{
    static void Main(string[] args)
    {

        int numero = 1;

        while (true)
        {
            if (numero % 7 == 0 && numero % 11 == 0)
            {
                Console.WriteLine($"El primer número divisible entre 7 y 11 es: {numero}");
                break;
            }
            numero++;
        }
    }