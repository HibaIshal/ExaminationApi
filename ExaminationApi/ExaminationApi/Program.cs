using ExaminationApi;

var builder = WebApplication.CreateBuilder(args);

// Lägg till tjänster om det behövs (vi har inga komplexa tjänster än)
var app = builder.Build();

// En enkel startsida så man vet att API:et lever
app.MapGet("/", () => "Välkommen till API:et!");

// Skapa en instans av min översättare
var translator = new Translator();

// Endpoint för att översätta text
// Exempel: /translate?text=hello
app.MapGet("/translate", (string text) =>
{
    var svar = translator.Translate(text);
    return Results.Ok(new { original = text, translated = svar });
});

app.Run("http://0.0.0.0:5000");