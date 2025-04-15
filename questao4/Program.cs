class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma letra:");
        char letra = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (IsVowel(letra))
        {
            Console.WriteLine($"{letra} é uma vogal.");
        }
        else
        {
            Console.WriteLine($"{letra} não é uma vogal.");
        }
    }

    static bool IsVowel(char c)
    {

        c = char.ToLower(c);

        return "aeiou".IndexOf(c) >= 0;
    }
}

