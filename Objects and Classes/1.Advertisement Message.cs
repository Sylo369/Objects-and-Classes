
class Program
{
    static void Test()
    {
        Advert phrases = new Advert(new List<string>()
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        });
        Advert events = new Advert(new List<string>()
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself,",
            "I am very satisfied.",
            "I feel great!"
        });
        Advert authors = new Advert(new List<string>()
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        });
        Advert cities = new Advert(new List<string>() 
        { 
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse" 
        });

        int numberAdverts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberAdverts; i++)
        {
            Console.WriteLine($"{phrases.MessageRandomizer()} {events.MessageRandomizer()} {authors.MessageRandomizer()} - {cities.MessageRandomizer()}");
        }
    }
}

public class Advert
{
    public Advert(List<string> quotes)
    {
        Quotes = quotes;
    }
    public List<string> Quotes { get; set; }

    public string MessageRandomizer()
    {
        Random random = new Random();
        return Quotes[random.Next(Quotes.Count)];

    }
}



