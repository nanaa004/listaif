class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine($"O aluno foi aprovado com nota {nota}");
        }
        else
        {
            Console.WriteLine($"O aluno foi reprovado com nota {nota}");
        }
    }
}

