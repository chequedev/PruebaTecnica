using Exercise_1_MinimalAPI.Modelos;
using Exercise_1_MinimalAPI.Servicios;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

#region Declaracion de Servicios
// Registro de la clase de servicio
builder.Services.AddTransient<IServicioOperacionesMatematicas, ServicioOperacionesMatematicasSimples>();

#endregion


var app = builder.Build();


#region Minimal API Opereciones Basicas
// Endpoint para Suma
app.MapPost("/api/Suma", (IServicioOperacionesMatematicas serviceOperacionesMat, Valores_Operacion data) =>
{
    try
    {
        var result = serviceOperacionesMat.Suma(data);
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        return Results.BadRequest($"Ha ocurrido un error: {ex.Message}");
    }
});

// Endpoint para Resta
app.MapPost("/api/Resta", (IServicioOperacionesMatematicas serviceOperacionesMat, Valores_Operacion data) =>
{
    try
    {
        var result = serviceOperacionesMat.Resta(data);
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        return Results.BadRequest($"Ha ocurrido un error: {ex.Message}");
    }
});

// Endpoint para Multiplicación
app.MapPost("/api/Multiplicacion", (IServicioOperacionesMatematicas serviceOperacionesMat, Valores_Operacion data) =>
{
    try
    {
        var result = serviceOperacionesMat.Multiplicacion(data);
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        return Results.BadRequest($"Ha ocurrido un error: {ex.Message}");
    }
});

// Endpoint para División
app.MapPost("/api/Dividir", (IServicioOperacionesMatematicas serviceOperacionesMat, Valores_Operacion data) =>
{
    try
    {
        var result = serviceOperacionesMat.Divicion(data);
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        return Results.BadRequest($"Ha ocurrido un error: {ex.Message}");
    }
});
#endregion

app.Run();
