class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast( string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpsodios => episodios.Count;

    public void AdicionarEpsodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast: {Nome} Apresentado por: {Host}\n");

        // Exibe os detalhes dos epsódios
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Epsódio {episodio.Ordem}:{episodio.Titulo}");
            Console.WriteLine($"Duração: {episodio.Duracao}");
            Console.WriteLine($"Resumo: {episodio.Resumo}\n");

        }

        //Exibe o total de episódios
        Console.WriteLine($"Este Podcast possui o total de episódios: {episodios.Count}");

    }
}