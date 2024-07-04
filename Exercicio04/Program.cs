// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("4- Escreva um programa que solicite ao usuário a informação da idade e do nome via teclado que deverão ser armazenados nas variáveis" +
    " idade do tipo int e nome do tipo string.A seguir realize o tratamento de erro e lançando as exceções considerando as seguintes condições:" +
    "\r\na- Se a idade é negativa, uma exceção ArgumentException é lançada com a mensagem \"A idade não pode ser negativa." +
    "\"\r\nb - Se a idade é zero, uma exceção NotImplementedException é lançada com a mensagem \"A idade ainda não foi definida." +
    "\"\r\nc- Se o nome é nulo ou vazio, uma exceção NullReferenceException é lançada com a mensagem \"O nome não pode ser nulo nem vazio\"" +
    "Nota: No item c use a expressão string.IsNullOrEmpty(nome)para verificar se o nome é null ou vazio.\r\n");
int idade = 0;
string nome = null;
try
{
    Console.Write("Informe a sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade < 0)
    {
        throw new ArgumentNullException("A idade não pode ser negativa.");
    }
    if (idade == 0)
    {
    throw new NotImplementedException("A idade ainda não foi definida.");
    }
    Console.Write("Informe o seu nome: ");
    nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome))
    {
        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
    }
    Console.WriteLine($"\nNome: {nome}, Idade: {idade}");
}
catch (ArgumentException e)
{
    Console.WriteLine("Erro de argumento: " + e.Message);
}
catch (NotImplementedException e)
{
    Console.WriteLine("Erro de implementação: " + e.Message);
}
catch (NullReferenceException e)
{
    Console.WriteLine("Erro de referência nula: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Erro inesperado: " + e.Message);
}
Console.ReadKey();