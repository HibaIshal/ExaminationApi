namespace ExaminationApi
{
    public class Translator
    {
        // Metod för att översätta
        public string Translate(string text)
        {
            // En säkerhetskoll: Om texte är tom, skicka tillbaka tomt
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            // Byter ut bokstäver mot siffror
            return text.Replace("e", "3")
                       .Replace("o", "0")
                       .Replace("a", "4")
                       .Replace("l", "1");
        }

        // För att avkryptera 
        public string Decrypt(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            // Byter tillbaka siffror till bokstäver
            return text.Replace("3", "e")
                       .Replace("0", "o")
                       .Replace("4", "a")
                       .Replace("1", "l");
        }
    }
}