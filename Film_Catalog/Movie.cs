using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class Movie : Title
    {
        public List<Title> Movies = new List<Title>();
        public Title Deadpool = new Movie();
        public Title Starwars = new Movie();
        public Title Ted = new Movie();
        public Title Jungle_Book = new Movie();
        public Title Captian_America = new Movie();
        public Title Grease = new Movie();
        public Title Titanic = new Movie();


        public void deadpool()
        {
            Deadpool.getname("Deadpool");
            //new string genre = "Action". "Comedy";
            Deadpool.getduration(215);
        }
        public void starwars()
        {
            Starwars.getname("StarWars");
            Starwars.getgenre("Action");
            Starwars.getduration(245);
        }
        public void ted()
        {
            Ted.getname("Ted");
            Ted.getgenre("Comedy");
            Ted.getduration(145);
        }
        public void junglebook()
        {
            Jungle_Book.getname("Jungle Book");
            Jungle_Book.getgenre("Action");
            Jungle_Book.getduration(200);
        }
        public void captianamerica()
        {
            Captian_America.getname("Capitan America");
            Captian_America.getgenre("Action");
            Captian_America.getduration(210);
        }
        public void grease()
        {
            Grease.getname("Grease");
            Grease.getgenre("Romance");
            Grease.getduration(200);
        }
        public void titanic()
        {
            Titanic.getname("Titanic");
            Titanic.getgenre("Romance");
            Titanic.getduration(300);
        }
    }
}
