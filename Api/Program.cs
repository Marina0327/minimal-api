using ControleBibliotecaApi.Dominio.DTOs;
using ControleBibliotecaApi.Dominio.Interfaces;
using ControleBibliotecaApi.Dominio.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Swagger + injeção de dependência
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILivroServico, LivroServico>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

// Endpoints
app.MapGet("/livros", async (ILivroServico servico) =>
{
    var livros = await servico.ListarAsync();
    return Results.Ok(livros);
});

app.MapPost("/livros", async (ILivroServico servico, LivroDTO dto) =>
{
    var livro = await servico.AdicionarAsync(dto);
    return Results.Created($"/livros/{livro.Id}", livro);
});

app.Run();
