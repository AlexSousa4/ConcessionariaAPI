using Concessionaria.Contexts;
using Concessionaria.Interfaces;
using Concessionaria.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ConcessionariaContext>(options =>
    // Diz que o banco é SQL Server e busca a connection string chamada "Escola"
    // dentro da seção ConnectionStrings do appsettings.json.
    options.UseSqlServer(builder.Configuration.GetConnectionString("Concessionaria")));


// NOVO: quando alguém pedir ICursoRepository, a API entrega um CursoRepository.
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/concessionaria", (ConcessionariaContext db) => db.Marca.ToList());

app.Run();
