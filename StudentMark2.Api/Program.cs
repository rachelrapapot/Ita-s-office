
using studentsMark2.Api;
using studentsMark2.Core;

using studentsMark2.Core.Repositories;
using studentsMark2.Data.Repositories;
using studentsMark2.servies;
using studentsMark2.Core.Services;
using studentsMark2;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICompaniesServies, CompaniesServies>();
builder.Services.AddScoped<ICompaniesRepositories, HiTechCompaniesRepositories_>();
builder.Services.AddScoped<IStudentServies, StudentServiescs>();
builder.Services.AddScoped<IStudntRepositories, StudentRepositories>();
builder.Services.AddScoped<ITeacherServies, TeacherServies>();
builder.Services.AddScoped<ITeacherRepositories, TeacherRepositories>();
builder.Services.AddSingleton<DataContext>();

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
