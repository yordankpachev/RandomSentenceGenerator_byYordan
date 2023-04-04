using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine($"Hello! This is our first random-generated sentence: ");

string[] names = { "Krasimir", "Ivaylo", "Nikola", "Stoycho", "Pavel", "Valentin" };
string[] places = { "Plovdiv", "Sofia", "Pleven", "Bourgas", "Varna", "Karlovo"};
string[] verbs = { "eats", "plays with", "holds", "sees", "drinks", "brings" };
string[] nouns = { "stones", "cake", "beer", "sandwich", "fruit", "laptop", "bikes" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "in the park", "at home", "near the river", "at work" };

while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlace = GetRandomWord(places);
    string randomVerb = GetRandomWord(verbs);
    string randomNoun = GetRandomWord(nouns);
    string randomAdverb = GetRandomWord(adverbs);
    string randomDetails = GetRandomWord(details);

    //Who from where [name + from + place]
    string who = $"{randomName} from {randomPlace}";
    //Action [adverb + verb + noun]
    string action = $"{randomAdverb} {randomVerb} {randomNoun}";
    string detail = $"{randomDetails}";

    Sentence sentence = new Sentence
    {
        Who = who,
        Action = action,
        Detail = detail
    };
    
    Console.WriteLine($"{sentence.Who} {sentence.Action} {sentence.Detail}...");
    Console.WriteLine("Click [Enter] to generate a new one.");

    if (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {
        break;
    }
}

static string GetRandomWord(string[] words)
{
    Random random= new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];
    return word;   
}

public class Sentence
{
    public string Who { get; set; }
    public string Action { get; set; }
    public string Detail { get; set; }  
}