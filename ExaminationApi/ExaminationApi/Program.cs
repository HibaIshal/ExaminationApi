using ExaminationApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Tog bort app.UseHttpsRedirection() här för att AWS Health Check ska fungera.

app.MapGet("/", () => "Webbplatsen fungerar!");

app.MapPost("/translate", (string text) =>
{
    var translator = new Translator();
    var result = translator.Translate(text);
    return result;
});

app.Run("http://0.0.0.0:5000");