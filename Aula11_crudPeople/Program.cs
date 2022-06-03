using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(
                x=>x.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
            );
IServiceCollection serviceCollection = builder.Services.AddScoped<IPersonRepository,PersonRepository>();
builder.Services.AddScoped<IAddressesRepository,AddressRepository>();
    
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
        
    

