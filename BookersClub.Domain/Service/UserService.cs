using BookersClub.Domain.Entities;
using BookersClub.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookersClub.Domain.Service
{
    public class UserService : IUserService
    {
        private BookersClubDBContext _db { get; set; }

        public UserService(BookersClubDBContext db)
        {
            this._db = db;
        }

        public User GetUserByUserName(string userName)
        {
            var user = this._db.User.Where(usr => usr.EmailAddress == userName).SingleOrDefault();
            return user;
        }
    }
}
