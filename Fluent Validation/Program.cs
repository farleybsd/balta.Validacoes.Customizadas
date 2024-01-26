using Fluent_Validation.Models;
using Fluent_Validation.Validators;
using FluentValidation;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IValidator<Usuario>, UsuarioValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/usuarios", (Usuario usuario, IValidator<Usuario> validator,HttpContext httpContext) =>
{
    var validationResult = validator.Validate(usuario);

    if (!validationResult.IsValid)
    {
        return Results.BadRequest(validationResult.Errors.Select(e => e.ErrorMessage));
    }

    return Results.Ok(usuario);
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
