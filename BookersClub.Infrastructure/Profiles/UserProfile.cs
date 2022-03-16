using AutoMapper;
using BookersClub.Domain.DTO;
using BookersClub.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookersClub.Infrastructure.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {

            CreateMap<UserForCreationDTO, User>();
            CreateMap<User, UserForCreationDTO>();
        }
    }
}
