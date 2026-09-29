/*Leia um número inteiro e informe se ele é par ou ímpar.

Só o enunciado. */

Console.WriteLine("Digite um numero");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O numero é Par");
}
else
{
    Console.WriteLine("O numero é impar");
}