using Microsoft.AspNetCore.Mvc;

public static class BasketEndpoints
{
    public static void MapBasketEndpoints(this WebApplication build)
    {
        build.MapGet("/baskets/", (IDataStore<BasketOfHerbs> repository) =>
        {
            return repository.ToList();
        })
        .Produces<BasketOfHerbs>(StatusCodes.Status200OK);

        build.MapPost("/baskets/", (IDataStore<BasketOfHerbs> repository) =>
        {
            return Results.BadRequest("Basket is not ready to be sent");
        })
        .Produces<BasketOfHerbs>(StatusCodes.Status201Created);


        build.MapPost("/baskets/{basketId}/herbs", (IDataStore<BasketOfHerbs> repository, IDataStore<Herb> herbRepository, int basketId, [FromQuery] int herbId) =>
        {
            return Results.BadRequest("Basket is not ready to be sent");
        })
        .Produces<BasketOfHerbs>(StatusCodes.Status201Created);


        build.MapPost("/baskets/{basketId}/send", (IDataStore<BasketOfHerbs> repository, int basketId) =>
        {
            return Results.BadRequest("Basket is not ready to be sent");
        })
        .Produces<Order>(StatusCodes.Status201Created);
    }
}
