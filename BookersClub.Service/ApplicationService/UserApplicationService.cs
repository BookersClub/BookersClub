using BookersClub.Domain.DTO;
using BookersClub.Domain.Entities;
using BookersClub.Domain.Interface;
using BookersClub.Infrastructure;
using BookersClub.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookersClub.Service.ApplicationService
{
    public class UserApplicationService : IUserApplicationService
    {

        private IUserService _userService { get; set; }



        public UserApplicationService(IUserService userService)
        {
            this._userService = userService;
        }

        public UserForCreationDTO GetUserByUserName(string username)
        {
            var user = this._userService.GetUserByUserName(username);
            var userToReturn = Mapping.Mapper.Map<UserForCreationDTO>(user);
            return userToReturn;
        }
    }
}
