using BookersClub.Domain.DTO;
using BookersClub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookersClub.Service.Interface
{
    public interface IUserApplicationService
    {
        public UserForCreationDTO GetUserByUserName(string username);
    }
}
