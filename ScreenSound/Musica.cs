class Musica
{

    //Contrtutor com parâmetro
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence á banda {Artista}"; //Propriedade somente leitura
   
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
    public void ExibirNomeEArtista ()
    {
        Console.WriteLine($"Nome/Artista: {this.Nome} - {this.Artista}");
    }
}