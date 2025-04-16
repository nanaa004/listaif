class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 == numero2)
        {
            Console.WriteLine("Os dois números são iguais.");
        }
        else
        {
            Console.WriteLine("Os dois números são diferentes.");
        }
    }
}
