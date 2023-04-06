Console.WriteLine($"Digite sua nota: ");
float nota = float.Parse(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Valor inválido, digite sua nota novamente: ");
    Console.ResetColor();
    nota = float.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Valor aceito!");
Console.ResetColor();





