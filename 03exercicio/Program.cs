/*Exercício 3 — Condicionais

Faça um programa que peça três números inteiros e exiba qual é o maior dos três (sem usar Math.Max, só com if/else).*/

int[] numeros = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite um numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int maior = numeros[0];

foreach (int n in numeros)
{
    if(n > maior)
    {
        maior = n;
    }
}

Console.WriteLine("O maior numero encontrado foi " + maior); 




