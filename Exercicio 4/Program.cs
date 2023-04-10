
// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

//Algoritimo

//entrada do sexo da pessoa
//se ela gostou do produto
//saber a quantidade de pessoas que responderam sim
//saber a quantidade de pessoas que responderam nao
//a quantidade de mulheres que responderam sim
//saber a quantidade total de mulheres que responderam
//saber a quantidade total de homens que responderam
//saber a porcentagem de homens que responderam nao

//declarar as variaveis

char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulherSim = 0;
int totalHomemNao = 0;

int totalMulher = 0;
int totalHomem = 0;

double porcentagemHomemNao = 0;

//estrutura do FOR
//int i = 1; inicializador
//i <= 3; condicional
//i++; iterador(incremento)

for (int i = 1; i <=10; i++)
{
    //entrada de dados
    Console.WriteLine(@$"
    Digite o sexo da pessoa
    (m) - Masculino
    (f) - Feminino
    ");
    
    sexo = char.Parse(Console.ReadLine().ToLower());

    //processamento
    if (sexo == 'f')
    {
        totalMulher++;
    }
    else if (sexo == 'm')
    {
        totalHomem++;
    }
    else
    {
        Console.WriteLine($"Digite novamente o caracter desejado!");
    }

    //entrada de dados
    Console.WriteLine(@$"
    A pessoa gostou do produto lancado
    (s) - Sim
    (n) - Nao
    ");

    gostouDoProduto = char.Parse(Console.ReadLine().ToLower());

    //processamento
    if (gostouDoProduto == 's')
    {
        totalSim++;

        if (sexo == 'f')
        {
            totalMulherSim++;
        }
    }
    else
    {
        totalNao++;

        if (sexo == 'm')
        {
            totalHomemNao++;
        }
    }
    
}

//processamento
porcentagemHomemNao = Math.Round(((double)totalHomemNao/(double)totalHomem)*100,3);

//saida
Console.WriteLine($"O total de pessoas que responderam sim foi de : {totalSim}");
Console.WriteLine($"O total de pessoas que responderam nao foi de : {totalNao}");
Console.WriteLine($"O total de mulheres que responderam sim foi de : {totalMulherSim}");
Console.WriteLine($"O total de homens que responderam nao foi de : {totalHomemNao}");



// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Digite seu gênero(Masculino ou Feminino): ");
//     Console.ReadLine().ToLower();

//     Console.WriteLine($"O produto testado agradou você? ");
//     Console.ReadLine().ToLower();
// }







