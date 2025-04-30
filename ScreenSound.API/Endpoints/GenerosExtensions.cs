using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Banco;
using ScreenSound.Shared.Modelos.Models;

namespace ScreenSound.API.Endpoints;

public static class GenerosExtensions
{

    public static void AddEndPointsGeneros(this WebApplication app)
    {
        #region ENDPOINT GENERO

        app.MapGet("/Generos", ([FromServices] DAL<Genero> dal) =>
        {
            return EntittyListToResponseList(dal.Listar());
        });

        app.MapGet("/Generos{nome}", ([FromServices] DAL<Genero> dal, string nome) =>
        {
            var genero = dal.RecuperarPor(g => g.Nome.ToUpper().Equals(nome.ToUpper()));
            if (genero is not null)
            {
                var response = EntityToResonse(genero!);
                return Results.Ok(response);
            }
            return Results.NotFound("Genero não encontrado.");
        });

        app.MapPost("/Generos", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequest generoRequest) =>
        {
            dal.Adicionar(RequestToEntity(generoRequest));
        });

        app.MapDelete("/Generos/{id}", ([FromServices] DAL<Genero> dal, int id) =>
        {
            var genero = dal.RecuperarPor(g => g.Id == id);
            if (genero is null)
            {
                return Results.NotFound("Gênero não encontrado!");
            }
            dal.Deletar(genero);
            return Results.NoContent();
        });
        #endregion
    }

    private static GeneroResponse EntityToResonse(Genero genero)
    {
        return new GeneroResponse(genero.Id, genero.Nome!, genero.Descricao!);
    }

    private static Genero RequestToEntity(GeneroRequest generoRequest)
    {
        return new Genero() { Nome = generoRequest.Nome, Descricao = generoRequest.Descricao };
    }

    private static ICollection<GeneroResponse> EntittyListToResponseList(IEnumerable<Genero> generoList)
    {
        return generoList.Select(a => EntityToResponse(a)).ToList();
    }

    private static GeneroResponse EntityToResponse(Genero genero)
    {
        return new GeneroResponse(
            genero.Id,
            genero.Nome!,
            genero.Descricao!
     );
    }
}