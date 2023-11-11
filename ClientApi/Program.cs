using ClientApi;
using ClientManagementApi.Application;
using ClientManagementApi.Application.Common.Interfaces;
using ClientManagementApi.Infrastrucure.Persistence;
using Microsoft.EntityFrameworkCore;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlite( builder.Configuration.GetConnectionString("myDb")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//TODO: unComment 
builder.Services.RegisterApplicationServices()
//.RegisterInfrastructureServices()
//.RegisterPersistenceServices(builder.Configuration)
.RegisterPresentationServices();

builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
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
