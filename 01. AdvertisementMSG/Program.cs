using System;

namespace _01._AdvertisementMSG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
                { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."};

            string[] events =
                { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};

            string[] authors =
                { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities =
                { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};            

            int spamCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < spamCount; i++)
            {
                string spamPhrase = phrases[GetRandomNumber(0, phrases.Length)];
                string spamEvent = events[GetRandomNumber(0, events.Length)];
                string spamAuthor = authors[GetRandomNumber(0, authors.Length)];
                string spamCity = cities[GetRandomNumber(0, cities.Length)];
                Console.WriteLine($"{spamPhrase} {spamEvent} {spamAuthor} – {spamCity}.");
            }

        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) 
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
