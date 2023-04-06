Console.WriteLine($"Digite um número: ");
float numeroDigitado = float.Parse(Console.ReadLine());


for (int i = 1; i <= 10;i++)
{
   float resultado = i * numeroDigitado;
   Console.WriteLine($"{numeroDigitado} * {i} = {resultado}");
}






