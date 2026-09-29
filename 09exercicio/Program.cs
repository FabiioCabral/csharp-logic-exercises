Console.WriteLine("Digite um lado do triangulo: ");
int lado = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo lado do triangulo: ");
int lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro lado do triangulo: ");
int lado3 = Convert.ToInt32(Console.ReadLine());
if (lado == lado2 && lado == lado3)
{
    Console.WriteLine("O triangulo é equilátero");
}
else if (lado == lado2 || lado == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triangulo é isoscele");
}
else
{
    Console.WriteLine("O triangulo é scaleno");
}
