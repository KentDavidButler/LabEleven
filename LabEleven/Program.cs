using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int choice;
                Movie[] movieList = FillMovieList();
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("");
                Console.WriteLine("There are tons of movies in this list. Pick a catagory:");
                Console.WriteLine("Press) 1 for Action: ");
                Console.WriteLine("Press) 2 for Animation: ");
                Console.WriteLine("Press) 3 for Comedy: ");
                Console.WriteLine("Press) 4 for Drama: ");
                Console.WriteLine("Press) 5 for Horror: ");

                choice = UserActions();
                ReturnMovies(choice, movieList);

                Console.WriteLine("");
                Console.Write("Continue? ");
            } while (YesOrNo());
        }

        private static void ReturnMovies(int choice, Movie[] movieList)
        {
            
            switch (choice)
            {
                case 1:
                    PullMovieFromList( movieList, "Action");
                    break;
                case 2:
                    PullMovieFromList( movieList, "Animation");
                    break;
                case 3:
                    PullMovieFromList(movieList, "Comedy");
                    break;
                case 4:
                    PullMovieFromList(movieList, "Drama");
                    break;
                case 5:
                    PullMovieFromList(movieList, "Horror");
                    break;
                default:
                    break;
            }
        }

        private static void PullMovieFromList(Movie[] movieList, string catagory)
        {
            //a little conveluded, but this method gets the array of movies
            //passes the movie titles that match the catagory from the array
            //and places the title in a list. Then the List gets sorted and
            //writen to console.
            List<String> titleList = new List<string> { };
            foreach (Movie title in movieList)
            {
                if (title.GetCategory() == catagory)
                    titleList.Add(title.GetTitle());
            }
            titleList.Sort();
            foreach (string title in titleList)
            {
                Console.WriteLine(title);
            }
        }

        public static int UserActions()
        {
            do
            {
                var input = Console.ReadKey();
                Console.WriteLine(" ");
                if (input.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("You chose Action!");
                    return 1;
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("You chose Animation!");
                    return 2;
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("You chose Comedy!");
                    return 3;
                }
                else if (input.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("You chose Drama!");
                    return 4;
                }
                else if (input.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("You chose Horror!");
                    return 5;
                }
                else
                {
                    Console.WriteLine("That is not an option.");
                    Console.WriteLine("Press 1 through 5 to choose a catagory.");
                }
            } while (true);

        }

        private static bool YesOrNo()
        {
            string input;
            while (true)
            {
                Console.Write("(y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry!");
                    continue;
                }
            }
        }

        private static Movie[] FillMovieList()
        {
            Movie[] movieList =
            {
               new Movie("Black Panther", "Action"),
               new Movie("A Star is Born", "Drama"),
               new Movie("Roma", "Drama"),
               new Movie("Blackkklansman", "Comedy"),
               new Movie("Avengers, Infinty War", "Action"),
               new Movie("Hereditary" , "Horror"),
               new Movie("A Quite Place" , "Horror"),
               new Movie("Annilation" , "Horror"),
               new Movie("Sorry to Bother You" , "Comedy"),
               new Movie("Can You Ever Forgive Me", "Comedy"),
               new Movie("Mission Impossible: Fallout", "Action"),
               new Movie("Eight Grade", "Comedy"),
               new Movie("Incredibles 2", "Animation"),
               new Movie("Spider-Man, Into the Spider-Verse", "Animation"),
               new Movie("Venom", "Action"),
               new Movie("Leave No Trace", "Drama"),
               new Movie("Burning", "Drama"),
               new Movie("Vice", "Comedy"),
               new Movie("Deadpool 2", "Action"),
               new Movie("Marry Poppins Returns", "Animation")
            };
            return movieList;
        }
    }
}
