Console.WriteLine("--- Calculador de notas ---\n");

Console.Write("Digite a nota 1.....:");
double nota1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a nota 2.....:");
double nota2 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a nota 3.....:");
double nota3 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a nota 4.....:");
double nota4 = double.Parse(Console.ReadLine()!);

if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10 || nota4 < 0 || nota4 > 10 ) 
{
    Console.WriteLine("\nDigite somente notas entre 0 e 10 ");
}    
else 
{
    double media = (nota1 + nota2 + nota3 + nota4 ) /4;
    Console.Write($"\nVocê ficou com media {media:f1}. Resultado: ");

    if (media < 5)
    {
        Console.WriteLine("Reprovado");
    }
    else if (media >= 5 && media < 6 )
    {
        Console.WriteLine("Em recuperação");
    }
    else
    {
        Console.WriteLine("Aprovado");
    }
}
