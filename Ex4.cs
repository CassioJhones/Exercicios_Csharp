Console.Clear();
Console.WriteLine("Texto:  ");
string texto = Console.ReadLine().ToLower();
string[] cortados = texto.Split(' '); //array vazio recebendo o texto cortado
var qtd = cortados.Count();

Console.WriteLine($"O numero de palavras é {qtd}");
