using Ecommerce.Infrastructure;
using Ecommerce.Infrastructure.Persistence;
using Ecommerce.Infrastructure.Repositories;
using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// --- 1. Service Registrations ---
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddOpenApi();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// --- 2. Middleware & Documentation ---
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); 
}

// --- 3. Organized Endpoint Groups ---
var products = app.MapGroup("/api/products")
                  .WithTags("Product Catalog");

// GET all products
products.MapGet("/", async (IProductRepository repo) => 
    Results.Ok(await repo.GetAllAsync()));

// POST new product
products.MapPost("/", async (Product product, IProductRepository repo) => 
{
    await repo.AddAsync(product);
    return Results.Created($"/api/products/{product.Id}", product);
});

app.Run();