//Método que chama a banda
Banda queen = new Banda("Queen");

Album albumDoQuenn = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQuenn.AdicionarMusica(musica1);
albumDoQuenn.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQuenn);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQuenn.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
