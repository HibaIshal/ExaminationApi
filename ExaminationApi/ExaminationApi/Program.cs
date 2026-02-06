using ExaminationApi;

var builder = WebApplication.CreateBuilder(args);

// Lägger till tjänster som behövs för API:et
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Konfigurerar Swagger så vi kan testa funktionerna
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// En enkel GET endpoint för att testa att webbplatsen fungerar
app.MapGet("/", () => "Webbplatsen fungerar!");

// Här ligger logiken för översättnigen som anropas via API
app.MapPost("/translate", (string text) =>
{
    var translator = new Translator();
    var result = translator.Translate(text);
    return result;
});

// Startar applikationen och lyssnar på port 5000
app.Run("http://0.0.0.0:5000");