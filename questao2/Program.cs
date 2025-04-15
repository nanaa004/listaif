class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if ((numero % 2) == 0)
            Console.WriteLine("é par");

    }
}
