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

// Vi behåller denna enkla startsida för att AWS Health Check ska bli grön
app.MapGet("/", () => "Webbplatsen fungerar!");

app.MapPost("/translate", (string text) =>
{
    var translator = new Translator();
    var result = translator.Translate(text);
    return result;
});

// Vi kör appen på alla nätverksgränssnitt på port 8080, vilket är standard för AWS Elastic Beanstalk
app.Run("http://0.0.0.0:8080");