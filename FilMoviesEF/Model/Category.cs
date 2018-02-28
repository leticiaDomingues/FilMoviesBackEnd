﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
