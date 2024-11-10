class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo =>
        $"Episódio: {Ordem}, Título: {Titulo}, {Duracao} min - Convidados: {string.Join(", ", convidados)}";
   
    public void AdicionarConvidados(string Convidado)
    {
        convidados.Add(Convidado);
    }

}