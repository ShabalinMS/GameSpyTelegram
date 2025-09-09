using GameSpyTelegram.Controllers;
using GameSpyTelegram.DB.GameSpy;
using GameSpyTelegram.DB.Repositories;
using GameSpyTelegram.DB.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<GameSpyContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("GameSpyPostgreSQL")));

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
