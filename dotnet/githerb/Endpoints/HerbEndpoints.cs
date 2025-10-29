public static class HerbEndpoints
{
    public static void MapHerbEndpoints(this WebApplication build)
    {
        build.MapGet("/herbs", (IDataStore<Herb> herbRepository) =>
         {
             return herbRepository.ToList();
         })
         .Produces<List<Herb>>(StatusCodes.Status200OK);
    }
}
