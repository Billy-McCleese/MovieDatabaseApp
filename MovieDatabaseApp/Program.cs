using MovieDatabaseApp;
using System;


List<MovieEntry> Movie = new List<MovieEntry>();

new MovieEntry() { Title = "Bugs Life", Category = "Animation" };
new MovieEntry() { Title = "Men in Black", Category = "Sci-Fi" };
new MovieEntry() { Title = "Good Will Hunting", Category = "Drama" };
new MovieEntry() { Title = "Hardball", Category = "Drama" };
new MovieEntry() { Title = "John Q", Category = "Drama" };
new MovieEntry() { Title = "Avatar", Category = "Animation" };
new MovieEntry() { Title = "Step Brothers", Category = "Comedy" };
new MovieEntry() { Title = "Mean Girls", Category = "Comedy" };
new MovieEntry() { Title = "Crazy Stupid Love", Category = "Rom-Com" };
new MovieEntry() { Title = "Mission Impossible", Category = "Action" };




do
{
    Console.WriteLine("There are 10 Movies in this List. \n Please Pick a category: ");

    string UserCategoryInput = Console.ReadLine();

/*    List<MovieEntry> OutputList = new List<MovieEntry>();
    foreach (var Movies in Movie)
    {
        OutputList.Add(new (Movies.Key, Movies.Value));
    }
*/

    Console.WriteLine("Search again?");
} while (Console.ReadLine() == "y");


//need to determine how to go through the list and output the movies based on category still. 