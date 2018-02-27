using FilMoviesAPI;
using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new FilMoviesContext())
            {
                try
                {
                    var user = new User() { Username = "let2", Password = "1233", Name = "Leticia Domingues2" };

                    ctx.Users.Add(user);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
