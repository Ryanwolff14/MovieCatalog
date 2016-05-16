using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Catalog
{
    public class Episode
    {

        private string[] Episodes = new string[size];
        static public int size = 25;


        public Episode()
        {
            for (int i = 0; i < size; i++)
                Episodes[i] = null;
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = Episodes[index];
                }
                else
                {
                    tmp = null;
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    Episodes[index] = value;
                }
            }
        }

        public static void showlist()
        {
            Episode num = new Episode();
            num[0] = "episode one <*****>";
            num[1] = "episode two <***>";
            num[2] = "episode three <*****>";
            num[3] = "episode four <*****>";
            num[4] = "episode five <**>";
            num[5] = "episode six <***>";
            num[6] = "episode seven <*****>";
            num[7] = "episode eight <*****>";
            num[8] = "episode nine <*****>";
            num[9] = "episode ten <***>";
            num[10] = "episode eleven <*****>";
            num[11] = "episode twelve <*****>";
            num[12] = "episode thirteen <*****>";
            num[13] = "episode fourteen <***>";
            num[14] = "episode fifteen <*****>";
            num[15] = "episode sixteen <***>";
            num[16] = "episode seventeen <*****>";
            num[17] = "episode eighteen <*****>";
            num[18] = "episode nineteen <****>";
            num[19] = "episode twenty <***>";
            for (int i = 0; i < Episode.size; i++ )
            {
                Console.WriteLine(num[i]);
            }
        }
        public double rating;


        public void setrating(double stars)
        {
            rating = stars;
        }


    }
}
