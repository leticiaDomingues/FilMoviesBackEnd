using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Model
{
    class Review
    {
        public int ReviewID { get; set; }
        public String Content { get; set; }
        public DateTime Date { get; set; }

        public String Username { get; set; }
        public User User { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}
