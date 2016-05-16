using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class Genre
    {
        public object genre;
        public static string Romance = "Romance";
        public static string Action = "Action";
        public static string Comedy = "Comedy";
        public string ActionComedy = string.Concat(Action, Comedy);
        public string RomanceComedy = string.Concat(Romance, Comedy);
        public string ActionRomance = string.Concat(Action, Romance);

        public string genre1;
        public string genre2;

        //Show.American_Dad;
        //Show.Apprenace;
        //Show.Archer;
        //Show.Breaking_Bad;
        //Show.FamilyGuy;
        //Show.Game_of_thrones;
        //Show.MrRogers;
        //Show.Nitro_Circus;
        //Show.Prettylittleliars;
        //Show.RobandBig;
        //Show.Rocket_Power;

    }
}
