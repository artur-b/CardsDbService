﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CardsDb.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<CardContext>(opt => opt.UseInMemoryDatabase("CardList"));
builder.Services.AddDbContext<CardContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CardsDatabase")));

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

