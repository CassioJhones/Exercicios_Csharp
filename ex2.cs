List<double> ListaInt = new List<double>();
Console.WriteLine("Digite uma lista de numeros separados or virgula: ");
string entrada = Console.ReadLine();
Console.WriteLine(entrada);

List<double> numeros = entrada.Split(',').Select(s => double.Parse(s.Trim())).ToList();

if (numeros.Count >0){
    double medio = numeros.Average();
    Console.WriteLine($"a Media é {medio}");
}else
    Console.WriteLine("ESTA VAZIA");

//Neste programa, pedimos ao usuário para inserir uma lista de números separados por vírgula.
//Em seguida, dividimos a entrada com Split(',') para obter uma matriz de strings. Usamos Select e double.Parse
//para converter essas strings em números reais e, em seguida, convertemos a matriz resultante em
//uma lista de números usando ToList().
