using System;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comedyData = new string[] {"Pulp Fiction", "Back to the Future", "Home alone", "Lock, Stock and Two Smoking Barrels" ,"Snatch"};
            string[] dramaData = new string[] { "Forrest Gump", "Fight Club", "Interstellar", "Titanic", "The Departed" };
            string[] fantasyData = new string[] { "Back to the Future", "The Mask", "Bruce Almighty", "Inception", "The Green Mile" };
            string[] thrillerData = new string[] { "Pulp Fiction", "Fight Club", "Shutter Island", "The Prestige", "The Butterfly Effect" };
            string[] actionData = new string[] { "Kingsman", "Mr. & Mrs. Smith", "Inception", "Avatar", "The Dark Knight" };
            Console.WriteLine("Greetings, my friend! I'm here to recommend you a movie for this evening");
            Console.WriteLine("How can i call you?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Pleased to meet you, " + inputName);
            Console.WriteLine("We have a library of comedy, drama, fantasy, thriller and action films. Which genre do you prefer?");
            string genre = Console.ReadLine().ToLower();
            switch (genre)
            {
                case "comedy":
                    DisplayData(comedyData);
                    break;
                case "drama":
                    DisplayData(dramaData);
                    break;
                case "fantasy":
                    DisplayData(fantasyData);
                    break;
                case "thriller":
                    DisplayData(thrillerData);
                    break;
                case "action":
                    DisplayData(actionData);
                    break;
                default:
                    Console.WriteLine("Sorry, we have no films of this genre.");
                    Console.ReadLine();
                    break;
            }
            void DisplayData(String [] collection)
            {
                Console.WriteLine("Thank you for your choice. Here is our list:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var film in collection)
                    Console.WriteLine("* " + film + " *");
                Console.ReadLine();
            }
        }
    }
}
