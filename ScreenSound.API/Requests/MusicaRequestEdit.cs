namespace ScreenSound.API.Requests
{
    public record MusicaRequestEdit (int Id, string nome, int anoLancamento)
        : MusicaRequest (nome,anoLancamento);
}
