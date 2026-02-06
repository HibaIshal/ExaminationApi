using ExaminationApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Webbplatsen fungerar!");

// Kryptera
app.MapPost("/translate", (string text) =>
{
    var translator = new Translator();
    // Sparar reslutatet från översättningen här
    var result = translator.Translate(text);
    return result;
});

// Avkryptera  
app.MapPost("/decrypt", (string text) =>
{
    var translator = new Translator();
    var result = translator.Decrypt(text);
    return result;
});

app.Run();