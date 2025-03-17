using (HttpClient client = new HttpClient() )
{
    string alunos = await client.GetAsync( "");
}