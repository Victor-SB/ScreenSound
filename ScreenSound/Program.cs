//Método que chama a banda
//Banda queen = new Banda("Queen");

//Album albumDoQuenn = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQuenn.AdicionarMusica(musica1);
//albumDoQuenn.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQuenn);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQuenn.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Episodio ep1 = new (2, "Tecnicas de facilitação", 45);
ep1.AdicionarConvidados("Victor Hugo");
ep1.AdicionarConvidados("Beatriz Soares");

Episodio ep2 = new(1, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("Bernardo");
ep2.AdicionarConvidados("Felipe");
ep2.AdicionarConvidados("Luciana");



Podcast podcast = new("Igão & Mitico", "PodPah");
podcast.AdicionarEpsodio(ep1);
podcast.AdicionarEpsodio(ep2);
podcast.ExibirDetalhes();


