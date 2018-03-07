﻿using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Login(User user);
        User Get(string username);

        new User Add(User user);
    }
}
