int idade, maiores = 0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite sua idade ");
    idade = int.Parse(Console.ReadLine());
    if (idade >= 18)
    {
        Console.WriteLine("Você é maior de idade ");
        maiores++;
    }

    Console.WriteLine(" A quantidade de pessoas maiores de idade é " + maiores);
}

