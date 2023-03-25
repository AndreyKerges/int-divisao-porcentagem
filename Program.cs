int n1,n2;

Console.Write("Digite um número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro  número: ");
n2 = Convert.ToInt32(Console.ReadLine());

int quociente, resto;

quociente = n1 / n2;
resto = n1 % n2;

Console.Write($" O quociente entre {n1} e {n2}");

// ":n3" ele mostra as casinhas que vai a virgula
Console.WriteLine($" é {quociente:n3} e sobra {resto:n3}");

