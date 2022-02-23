using PubDev.Nuget.HttpMiddleware;

var builder = WebApplication.CreateBuilder(args);

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

app.UsePubDev();

app.MapGet("/", () =>
{
    return new { success = true };
});

app.MapGet("/error", () =>
{
    throw new Exception("Error");
});

app.Run();