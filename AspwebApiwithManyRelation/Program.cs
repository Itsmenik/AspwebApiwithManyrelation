using AspwebApiwithManyRelation.Data.Entities;
using Microsoft.EntityFrameworkCore; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();// support controller for our api                 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CustomerDbContext>( option =>
{
    option.UseSqlServer("Data Source = 10.168.16.78\\MSSQLSRV2019; Initial Catalog = SQLTraining; User ID = AWLDhrishti; Password=AWLDhrishti;Encrypt=False");
}); 

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






