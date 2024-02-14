﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EMS_Full_Stack.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EMS_Full_StackContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EMS_Full_StackContext") ?? throw new InvalidOperationException("Connection string 'EMS_Full_StackContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
