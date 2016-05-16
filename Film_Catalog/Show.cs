using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class Show : Title
    {
        public List<Title> Shows = new List<Title>();
        Title American_Dad = new Title();
        Title Archer = new Title();
        Title Game_of_thrones = new Title();
        Title Pretty_little_liars = new Title();
        Title Breaking_Bad = new Title();
        Title Nitro_Circus = new Title();
        Title RobandBig = new Title();
        Title MrRogers = new Title();
        Title Rocket_Power = new Title();
        Title Apprentice = new Title();
        Title FamilyGuy = new Title();



        public void americandad()
        {
            American_Dad.getname("American Dad");
            American_Dad.getgenre("Comedy");
            Episode.showlist();
        }

        public void archer()
        {
            Archer.getname("Archer");
            //new Genre.Archer +("Comedy", "Action")
        }

        public void got()
        {
            Game_of_thrones.getname("Game of Thrones");
            Game_of_thrones.getgenre("Action");
        }

        public void prettylittleliars()
        {
            Pretty_little_liars.getname("Pretty Little Liars");
            Pretty_little_liars.getgenre("Romance");
        }

        public void breakingbad()
        {
            Breaking_Bad.getname("Breaking Bad");
            Breaking_Bad.getgenre("Action");
        }

        public void nitrocircus()
        {
            Nitro_Circus.getname("Nitro Circus");
            Nitro_Circus.getgenre("Action");
        }

        public void robandbig()
        {
            RobandBig.getname("Rob and Big");
            RobandBig.getgenre("Comedy");
        }

        public void mrrogers()
        {
            MrRogers.getname("Mr. Rogers");
            MrRogers.getgenre("Comedy");
        }

        public void rocketpower()
        {
            Rocket_Power.getname("Rocket Power");
            Rocket_Power.getgenre("Comedy");
        }

        public void apprentice()
        {
            Apprentice.getname("Apprentice");
            Apprentice.getgenre("Action");
        }

        public void familyguy()
        {
            FamilyGuy.getname("Family Guy");
            FamilyGuy.getgenre("Comedy");
        }

    }
}
