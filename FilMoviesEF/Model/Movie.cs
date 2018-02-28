using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Model
{
    public class Movie
    {
        public int MovieID { get; set; }
        public String Title { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public float Rate { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<MovieWatched> MoviesWatched { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Director> Directors { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
