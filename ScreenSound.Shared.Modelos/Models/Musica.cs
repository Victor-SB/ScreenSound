using ScreenSound.Shared.Modelos.Models;

namespace ScreenSound.Modelos;
public class Musica
{
    public Musica()
    {
       
    }

    //Contrtutor com parâmetro
    public Musica(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; } = string.Empty;
    public int Id { get; set; }
    public int Duracao { get; internal set; }
    public int? AnoLancamento { get; set; }
    public int? ArtistaId { get; set; }
    public virtual Artista? Artista { get; set; }
    public virtual ICollection<Genero> Generos { get; set; }

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