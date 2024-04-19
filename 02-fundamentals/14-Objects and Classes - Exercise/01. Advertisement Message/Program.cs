string[] phrases = new string[]
{
    "Excellent product.", "Such a great product.", 
    "I always use that product.", 
    "Best product of its category.", 
    "Exceptional product.", 
    "I can't live without this product."
};

string[] events = new string[]
{
    "Now I feel good.", 
    "I have succeeded with this product.", 
    "Makes miracles. I am happy of the results!", 
    "I cannot believe but now I feel awesome.", 
    "Try it yourself, I am very satisfied.", 
    "I feel great!"
};
string[] authors = new string[]
{
    "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
};
string[] cities = new []
{
    "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
};

int lines = int.Parse(Console.ReadLine());

Random rnd = new Random();

for (int i = 0; i < lines; i++)
{
    string phrase = phrases[rnd.Next(0, phrases.Length)]; 
    string eventx = events[rnd.Next(0, events.Length)];
    string author = authors[rnd.Next(0, authors.Length)];
    string city = cities[rnd.Next(0, cities.Length)];
    Console.WriteLine($"{phrase} {eventx} {author} – {city}.");
}
