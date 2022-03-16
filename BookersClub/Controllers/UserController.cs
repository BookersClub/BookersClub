using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookersClub.Domain.DTO;
using BookersClub.Service.Interface;

namespace BookersClub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private IUserApplicationService _userApplicationService { get; set; }
        public UserController(IUserApplicationService userApplicationService) 
        {
            this._userApplicationService = userApplicationService;
        }

        [HttpGet]
        public ActionResult<UserForCreationDTO> Get()
        {

            var user = this._userApplicationService.GetUserByUserName("sriram.sakinala@gmail.com");
            return Ok(user);
        }

    }
}
