using Microsoft.EntityFrameworkCore;
using WebService.BLL.Interfaces;
using WebService.BLL.Services;
using WebService.DAL.Data;
using WebService.DAL.Repositories;
using WebService.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DbContext 

builder.Services.AddDbContext<WebServiceDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
#endregion

#region Injections 

builder.Services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
builder.Services.AddScoped<IUtilisateurService, UtilisateurService>(); 
#endregion

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
