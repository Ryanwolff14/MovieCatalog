using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class View
    {
    

        public static void ShowTitle()
        {
            Console.WriteLine("Would you like to view 1=Movies or 2=TV shows?>");
            string answer = null;
            answer = Console.ReadLine();
            if (answer.Equals("1"))
            {
                ShowShows();
            }
            else if (answer.Equals("2"))
            {
                ShowMovies();
            }
            else
            {
                Console.WriteLine("Wrong input please use either 1 or 2");
                ShowTitle();
            }
            
        }

        public static void ShowShows()
        {
            Console.WriteLine("Welcome to the TV show section");
            Console.WriteLine("The shows we have are");

        }
        public static void ShowMovies()
        {
            Console.WriteLine("Welcome to the movie section");
            Console.WriteLine("The movies we have are");
            Console.WriteLine("Movie 1", Movie.Deadpool);

        }

    }
}
