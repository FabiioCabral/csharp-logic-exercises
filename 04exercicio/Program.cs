/* Faça um programa que peça um número inteiro e informe:

Se ele é par ou ímpar
Se ele é positivo, negativo ou zero*/
Console.WriteLine("Digite um numero para saber se ele é Impar ou Par");
int n = Convert.ToInt32(Console.ReadLine());
while(n != 0)
{
    Console.WriteLine("Digite um numero para saber se ele é Impar ou Par");
    n = Convert.ToInt16(Console.ReadLine());
        if(n % 2 == 0)
    {
        Console.WriteLine("O umero é par");
    }
    else
    {
        Console.WriteLine("O numer é impar");
    }
    
}

Console.WriteLine("Você saiu do programa");