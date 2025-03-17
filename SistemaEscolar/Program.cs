using (HttpClient client = new HttpClient() )
{
   try
    {
        string alunos = await client.GetStringAsync("https://raw.githubusercontent.com/KaykyCristof/C-API/refs/heads/master/SistemaEscolar/API/Alunos.json");
        Console.WriteLine( alunos );
    }
    catch( Exception ex )
    {
        Console.WriteLine( $"Tivemos um erro: {ex.Message}" );
    }
}