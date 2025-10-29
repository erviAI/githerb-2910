var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDataStore<Herb>>(new InMemoryDataStore<Herb>(HerbsSeeder.SeedHerbs()));
builder.Services.AddSingleton<IDataStore<BasketOfHerbs>>(new InMemoryDataStore<BasketOfHerbs>());

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapHerbEndpoints();
app.MapBasketEndpoints();

// Default route to swagger
app.MapGet("/", () => Results.Redirect("/swagger")).ExcludeFromDescription();

app.Run();

