using ExaminationApi;

var builder = WebApplication.CreateBuilder(args);

// Lägger till stöd för API dokumentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktiverar Swagger om appen körs i utvecklingsmiljö
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Sida för att kontrolera att webbplatsen är igång
app.MapGet("/", () => "Webbplatsen fungerar!");

// Punkt för att ta emot text och skicka tillbaka översättning
app.MapPost("/translate", (string text) =>
{
    var translator = new Translator();
    var result = translator.Translate(text);
    return result;
});

// Startar applikationen
app.Run();