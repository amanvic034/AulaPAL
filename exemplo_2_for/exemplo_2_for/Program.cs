int idade;
Console.WriteLine("Digite sua idade ");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Repetção até sua idade");
for (int i = 0; i <= idade; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(i);
}
