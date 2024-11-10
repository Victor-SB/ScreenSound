class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast( string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpsodios => episodios.Sum(e => e.Ordem);

    public void AdicionarEpsodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast {Nome} Host: {Host}");
        // Ordena a lista de episódios por sequência
        episodios.Sort((e1, e2) => e1.Titulo.CompareTo(e2.Titulo));
        // Exibe os detalhes dos epsódios
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine($"Epsódio {episodio.Ordem}:{episodio.Titulo}");
            Console.WriteLine($"Duração: {episodio.Duracao}");
            Console.WriteLine($"Resumo: {episodio.Resumo}");

        }

        //Exibe o total de episódios
        Console.WriteLine($"Total de episódios: { episodios.Count}");

    }
}