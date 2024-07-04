// See https://aka.ms/new-console-template for more information
Console.WriteLine("5- Dado um array de inteiros expresso da seguinte formaint[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };" +
    "Exiba na janela do console os numeros do array e solicite via teclado ao usuário para informar o valor de um índice " +
    "do array para obter o seu respectivo valor.Tratamento de erros Realize o tratamento de exceções filtrando as exceções IndexOutOfRangeException" +
    " e ArgumentNullException\n");
int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
Console.WriteLine("Números no array:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"[{i}] - {numeros[i]}");
}
try
{
    Console.Write("\nInforme um índice para obter o valor correspondente: ");
    int indice = int.Parse(Console.ReadLine());
    int valor = numeros[indice];
    Console.Write($"\nO valor no índice {indice} é: {valor}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Erro: O índice está fora do intervalo válido.");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Erro: A entrada não pode ser nula.");
}
finally
{
    Console.WriteLine(" Fim do programa!");
}

Console.ReadKey();