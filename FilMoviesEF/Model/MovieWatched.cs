using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Model
{
    public class MovieWatched
    {
        public Boolean? Favorite { get; set; }
        public float? Rate { get; set; }


        public String Username { get; set; }
        public User User{ get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}
