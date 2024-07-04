
Console.WriteLine("3 - Escreva um program onde o usuário é solicitado a informar um valor via teclado e armazenar o valor na variável entrada do tipo " +
    "string onde tem que verificar 3 condições diferentes:" +
    "\r\na- Se a entrada é nula, uma exceção ArgumentNullException é lançada com a mensagem \"A entrada não pode ser nula.\" (Verifique a diferença entre" +
    " ArgumentException e ArgumentNullException)" +
    "\r\nb-Se a entrada está vazia, uma exceção ArgumentException é lançada com a mensagem \"A entrada não pode estar vazia." +
    "\"\r\nc-Se a entrada passar nas verificações anteriores, a entrada é exibida na tela.Realize o tratamento de erro para essas condições usando o bloco " +
    "try-cath-finally\n");
string entrada = null; // Variável para armazenar a entrada do usuário
try
{
    Console.Write("Informe um valor: ");
    entrada = Console.ReadLine(); // Lê a entrada do usuário
    if (entrada == null)
    {
        throw new ArgumentNullException("entrada", "A entrada não pode ser nula.");
    }
    else if (string.IsNullOrWhiteSpace(entrada))
    {
        throw new ArgumentException("A entrada não pode estar vazia", "entrada");
    }
    else
    {
        Console.WriteLine("Entrada: " + entrada); // Exibe a entrada
    }
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
finally
{
    // O bloco finally será executado independentemente de ter ocorrido uma exceção ou não
    Console.WriteLine("\nFim do programa");
}
Console.ReadKey();