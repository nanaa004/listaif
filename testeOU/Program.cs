string cargo;

Console.WriteLine("Informe qual seu cargo na universidade: ");
cargo = Console.ReadLine();

if (cargo == "aluno" || cargo == "professor")
        {
    Console.WriteLine("Você pode entrar:D");
}
else
{
    Console.WriteLine("Não pode entrar:(");
}