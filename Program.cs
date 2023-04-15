string resultado;
double nota1, nota2,nota3, nota4, media;

Console.WriteLine("--- Média de 4 notas ---");

Console.Write("Digite a nota 1 ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 2 ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 3 ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 4 ");
nota4 = Convert.ToDouble(Console.ReadLine());

bool todasnotas = nota1 >=0 && nota1 <= 10
                && nota2 >=0 && nota2 <= 10
                && nota3 >=0 && nota3 <= 10
                && nota4 >=0 && nota4 <= 10;

media = (nota1 + nota2 + nota3 + nota4) /4;         

if (media < 5)
{
     resultado = "infelizmente você não foi aprovado";
}
else
{
    if (media > 6)
    {
        resultado = "você está aprovado";
    }

    else
    {
        resultado = "você está de recuperação";
    }
}

if (todasnotas)
{
Console.WriteLine($"Sua média final é de {media:N1}. Resultado: {resultado} ");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Digite notas entre 0 e 10. ");
    Console.ResetColor();
}


