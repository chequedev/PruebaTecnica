using Exercise_2_Crud_Employees.DataContext;
using Exercise_2_Crud_Employees.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContextApp>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("Connection_db"));
});

builder.Services.AddTransient<IRepositoryEmployees,RepositoryEmployees>();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
