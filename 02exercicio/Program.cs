/*Exercício 2 — Condicionais (if/else)

Peça ao usuário para digitar uma nota (de 0 a 10)
Classifique a nota da seguinte forma:
0 a 4,9 → "Reprovado"
5 a 6,9 → "Recuperação"
7 a 10 → "Aprovado"
Exiba a classificação na tela

Bônus (se quiser ir além): valide se o número digitado está entre 0 e 10 — se estiver fora disso, exiba "Nota inválida".*/

Console.WriteLine("Digite sua nota");
double nota = Convert.ToDouble(Console.ReadLine());

while(nota < 0 || nota > 10)
{
    Console.WriteLine("Nota invalida, digite corretamente:");
    nota = Convert.ToDouble(Console.ReadLine());
    
}
if (nota >= 0 && nota < 5)
{
    Console.WriteLine("Reprovado");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Recuperação");
}
else if (nota >= 7 && nota < 10)
{
    Console.WriteLine("Aprovado");
}
