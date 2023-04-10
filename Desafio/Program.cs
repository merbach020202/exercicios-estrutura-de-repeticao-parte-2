

////// ANDRÉ
// int a = 1;
// int b = 1;

// do
// {
//     Console.WriteLine($"a={a} + b={b} ainda e menor do que 500");
//     a = a + b;
//     b = b + a;
// } 
// while (a < 500);


//////// PROFESSOR
////// FIBONACCI COM WHILE
Console.WriteLine($"Série de fibonacci");

int num1 = 0;
int num2 = 1;
int auxiliar;

for (int i = 0; i < 500; i++)
{
    auxiliar = num1;
    num1 = num2;
    num2 = num1 + auxiliar;

    Console.WriteLine(num2);

    if (num2 > 500)
    {
        break;
    }
    
}




