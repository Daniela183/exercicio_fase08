//aula 174
Console.WriteLine("Exercício - Tratamento Exceção\n");
try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");
    Console.Write("Informe o nome do arquivo: ");
    string? arquivo = Console.ReadLine();
    Console.Write("Informe a url do site: ");
    string? url = Console.ReadLine();
    Console.WriteLine("\nAguarde...");

    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url + "/" + arquivo).Result;

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("\nAcesso ao arquivo feito com sucesso");
        Console.WriteLine("\nCódigo de status: " + response.StatusCode);
    }
    else
    {
        throw new HttpRequestException("\nErro: " + response.StatusCode);
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("\nPágina não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("\nAcesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("\nRequisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("\nErro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("\nProcessamento concluído");
}

Console.ReadKey();