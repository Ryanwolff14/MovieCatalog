using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("would you like to view a show?");
            Console.ReadKey();
            Episode.showlist();
            Console.ReadKey();
        }
    }
}
