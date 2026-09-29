/*Leia três notas de um aluno, calcule a média e informe a situação final:

média maior ou igual a 7 → aprovado
média entre 5 e 6,9 → recuperação
média menor que 5 → reprovado*/

double soma = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite a nota");
    double nota = Convert.ToDouble(Console.ReadLine());
    soma = soma + nota; 
}

double media = soma / 3; 

if(media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if(media >= 5 && media < 7)
{
    Console.WriteLine("Recuperação");
}
else if (media < 5 )    
{
    Console.WriteLine("Reprovado");
}
else
{
    Console.WriteLine("media invalidade");
}