Console.WriteLine("Digite o primeiro numero");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"{n1} foi o maior numero digitado");

}
else if (n2 > n1)
{
    Console.WriteLine($"{n2} foi o maior numero digitado");
}    
else
{
    Console.WriteLine("São iguais");
}