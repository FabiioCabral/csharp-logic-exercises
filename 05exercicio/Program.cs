/*Exercício 01 — Classificação de número

Leia um número inteiro e informe se ele é:

positivo;
negativo;
zero.*/

int num = 0;

do
{
    Console.WriteLine("Digite um numero para saber se ele é positivo, negativo ou neutro");
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        Console.WriteLine("Numero Positivo");
    }
    else if (num < 0)
    {
        Console.WriteLine("Negativo");
    }
    else
    {
        Console.WriteLine("Neutro");
    }
        
    
}
while (num != 0);

