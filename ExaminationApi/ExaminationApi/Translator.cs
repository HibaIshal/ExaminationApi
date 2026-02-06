namespace ExaminationApi
{
    public class Translator
    {
        // Metod för att översätta texten
        public string Translate(string text)
        {
            // En säkerhetskoll: Om texte är tom, skicka tillbaka tomt
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            // Här byter vi ut vissa bokstäver mot siffror för att göra texten svårare att läsa
            string result = text.Replace("e", "3")
                                .Replace("o", "0")
                                .Replace("a", "4")
                                .Replace("l", "1");

            return result;
        }
    }
}