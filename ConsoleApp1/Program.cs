class Program
{
    public static void Main()
    {
        string senha = "1234"; // Senha correta definida

        Console.WriteLine("Digite a senha: ");
        string entrada = Console.ReadLine();

        if (entrada == senha)
        {
            Console.WriteLine("Senha correta. Acesso permitido!");
        }
        else
        {
            Console.WriteLine("Senha incorreta. Acesso negado.");
        }
    }
}
