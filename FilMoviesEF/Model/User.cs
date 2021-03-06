﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Model
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<MovieWatched> MoviesWatched { get; set; }
    }
}
