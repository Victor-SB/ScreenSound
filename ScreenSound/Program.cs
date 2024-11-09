Album albumDoQuenn = new Album();
albumDoQuenn.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 364;

albumDoQuenn.AdicionarMusica(musica1);
albumDoQuenn.AdicionarMusica(musica2);

albumDoQuenn.ExibirMusicasDoAlbum();