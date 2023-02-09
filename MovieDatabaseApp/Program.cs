using MovieDatabaseApp;
using System;
using System.Linq;

string UserCategoryInput;
String SearchAgain;
bool UserCategoryInputExists;
List<MovieEntry> Movie = new List<MovieEntry>()
{
    new MovieEntry() { Title = "bugs life", Category = "animation" },
    new MovieEntry() { Title = "men in black", Category = "sci-fi" },
    new MovieEntry() { Title = "good will hunting", Category = "drama" },
    new MovieEntry() { Title = "hardball", Category = "drama" },
    new MovieEntry() { Title = "john q", Category = "drama" },
    new MovieEntry() { Title = "avatar", Category = "animation" },
    new MovieEntry() { Title = "step brothers", Category = "comedy" },
    new MovieEntry() { Title = "mean girls", Category = "comedy" },
    new MovieEntry() { Title = "crazy stupid love", Category = "rom-com" },
    new MovieEntry() { Title = "mission impossible", Category = "action" }
};

Console.WriteLine("There are 10 Movies in this List");

do
{
    Console.WriteLine("Please Pick a category: ");
    UserCategoryInput = Console.ReadLine().ToLower();

    List<MovieEntry> SearchResults = Movie.Where(item => item.Category.Contains(UserCategoryInput)).ToList();
    int ResultCount = SearchResults.Count();

    if (ResultCount > 0)
    {
        foreach (var item in SearchResults)
        {
            Console.WriteLine(item.Title);
        }
    }
    else
    {
        Console.WriteLine("That category doesn't exist.");
    }




    Console.WriteLine();
    Console.WriteLine("Search again? (y/n)");
    SearchAgain = Console.ReadLine().ToLower();
} while (SearchAgain == "y");




