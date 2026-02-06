using ExaminationApi;

var builder = WebApplication.CreateBuilder(args);

// Lägger till stöd för API dokumentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktiverar Swagger för att kunna se API dokumentationen
app.UseSwagger();
app.UseSwaggerUI();

// En enkel startsida så man ser att servern lever
app.MapGet("/", () => "Webbplatsen fungerar!");

// Här definierar vi en POST endpoint som tar emot text och returnerar den översatta versionen
app.MapPost("/translate", (string text) =>
{
    // Skapar en ny översättare och sparar resultatet
    var translator = new Translator();
    var result = translator.Translate(text);
    return result;
});

// Startar igång appen
app.Run();