using Microsoft.EntityFrameworkCore;
using MVCWebAppTestAPI.DBModels;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("CandidateConnection");
builder.Services.AddDbContext<CandidateContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<ICandidateContext, CandidateContext>();

builder.Services.AddControllers();
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
