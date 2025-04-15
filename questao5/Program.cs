class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0)
        {
            Console.WriteLine($"{numero} é múltiplo de 3");
        }
        else
        {
            Console.WriteLine($"{numero} não é multiplo de 3");
        }
          

    }
}
