using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class Title
    {
        public string name = null;
        public double rating;
        public double duration;
        public string genre = null;
        public string genre1 = null;
        public string genre2 = null;

        public void getname(string title)
        {
            name = title;
        }

        public void getrating(double stars)
        {
            rating = stars;
        }

        public void getduration(double length)
        {
            duration = length;
        }

        public void getgenre(string type)
        {
            string genre = type;
        }

        //public static Genre operator+ (string genre1, string genre2)
        //{
        //    string genre = string genre1 && string genre2;
        //}
    }
}
