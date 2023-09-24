Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();
frase = frase.ToLower();
int ContVogal = 0;

foreach (char letra in frase){//para cada letra na frase ele irá verificar
    if (letra == 'a'|| letra == 'e'|| letra == 'i'|| letra == 'o'|| letra == 'u')
        ContVogal++;}

Console.WriteLine($"Qtd de vogais: {ContVogal}");
