//tipo    |  nome    |   nova instancia
List<int> ListaOriginal = new List<int> { 2,3,2,5,8,8,5,10,10,11};
Console.WriteLine("Lista original: " + string.Join(", ",ListaOriginal));
Console.WriteLine(ListaOriginal);
List<int> ListaSemCopias = ListaOriginal.Distinct().ToList();   
Console.WriteLine("Lista sem duplicatas: "+ string.Join(", ",ListaSemCopias));

//string.Join é usado para formatar a saída de forma mais amigável,
//tornando-a mais fácil de ler e entender,
//especialmente quando se lida com listas de elementos. Ele ajuda a transformar
//uma lista em uma única string formatada,
//facilitando a exibição na tela ou em outros contextos de saída.
