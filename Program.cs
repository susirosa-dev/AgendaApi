using AgendaApi.Data;
using Microsoft.EntityFrameworkCore;
using AgendaApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Cria um objeto ContatoService por requisição HTTP.
builder.Services.AddScoped<ContatoService>(); 

// AgendaContext é o objeto que representa a sessão de trabalho com o banco,
// permitindo consultar, inserir, alterar e excluir dados.
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
