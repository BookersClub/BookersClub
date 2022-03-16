using BookersClub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookersClub.Domain.Interface
{
    public interface  IUserService
    {
        public User GetUserByUserName(string userName);        
    }
}
