using ApiTesteUpbase.Context;
using ApiTesteUpbase.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\karla\\Documents\\apiteste.mdf;Integrated Security=True;Connect Timeout=30;"));

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.MapPost("AdicionarAluno", async (Aluno aluno, Context context) =>
{
    context.aluno.Add(aluno);
    await context.SaveChangesAsync();
});

app.MapGet("ListaAlunos", async (Context context) =>
{
    return await context.aluno.ToListAsync();
});

app.UseSwaggerUI();
app.Run();


