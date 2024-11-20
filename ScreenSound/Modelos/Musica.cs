namespace ScreenSound.Modelos;
class Musica
{

    //Contrtutor com parâmetro
    public Musica(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public int Duracao { get; internal set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");

    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}