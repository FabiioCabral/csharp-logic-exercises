/* Exercício 1 — Estruturas sequenciais e variáveis
Faça um programa em C# que: 
1- Peça ao usuário para digitar seu nome, idade e altura (em metros)
2- Calcule em que ano essa pessoa completará 100 anos
3- Exiba uma mensagem formatada assim:*/

Console.WriteLine("Qual é o seu nome?");
    string? nome = Console.ReadLine();
Console.WriteLine("Qual é a sua altura?");
    double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual é a sua idade?");
    int idade = Convert.ToInt32(Console.ReadLine());
int ano = (100 - idade) + 2026;

Console.WriteLine($"Olá, {nome} você tem {idade} anos e {altura}m de altura. Você completará 100 anos em {ano}.");


