class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual a sua idade?");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 16)
            Console.WriteLine("Você pode votar.");
        else
            Console.WriteLine("Você não pode votar.");
    }
}