Console.WriteLine($"Digite seu nome de usuário: ");
string usuario = Console.ReadLine().ToLower();

Console.WriteLine($"Digite sua senha (Digite no máximo 6 caracteres): ");
string senha = Console.ReadLine();

while (usuario == senha)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"O nome de usuário nao pode ser igual a sua senha!");
    Console.ResetColor();
    senha = Console.ReadLine();

}


if (senha.Length > 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Digite uma senha válida!");
    Console.ResetColor();
    Console.ReadLine();
}

else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Usuário e senha aceitos!");
    Console.ResetColor();
}



