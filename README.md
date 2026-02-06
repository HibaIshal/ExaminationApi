
# ExaminationApi
ExaminationApi är ett enkelt C# Web API för textöversättning som byter ut bokstäver mot siffror. Projektet använder GitHub Actions för CI/CD och är konfigurerat för automatiskt distribution till AWS Elastic Beanstalk.

Det finns ingen frontend i projektet utan interaktionen sker via API endpoints eller genom Swagger gränssnittet som visar hur koden fungerar live.

🚀 Kom igång

1. Klona repot: git clone https://github.com/HibaIshal/ExaminationApi.git

2. Gå till mappen: cd ExaminationApi

3. Kör API lokalt: dotnet run

API:t är tillgängligt live på: http://examinationapiv3-env.eba-ijbpybc2.eu-north-1.elasticbeanstalk.com/.


⚙️ Endpoints

* GET /: Enkel kontroll för att se att servern lever.

* POST /translate: Används för att översätta text. Skicka in en sträng så byts 'e', 'o', 'a' och 'l' ut mot siffror.


🌲 Git Flow
Projektet följer en enkel version av Git Flow strategin:

* main: Stabil produktionskod som deployas till AWS.

* feature/: Här utvecklas de nya fuktionerna innan de mergas in i huvudkoden.
  

🔁 CI/CD med GitHub Actions

Varje gång kod pushas till main branchen händer följande automatiskt:

✔ GitHub Actions bygger projektet med .NET 9.

✔ Koden publiceras och skickas till AWS Elastic Beanstalk för distribution.


📦 Tekniker

* C# / .NET 9.

* GitHub Actions (CI/CD).

* AWS Elastic Beanstalk.

* Swagger för dokumentation och testning.
