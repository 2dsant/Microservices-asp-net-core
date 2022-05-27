using GeekShopping.ProductApi.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string mySqlConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MySQLContext>
(options => options.UseMySql(
    mySqlConnectionString,
    ServerVersion.AutoDetect(mySqlConnectionString))
);

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
