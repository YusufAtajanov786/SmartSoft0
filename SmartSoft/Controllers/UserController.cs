using AutoMapper;
using Contracts;
using Entities.DTO;
using Entities.Model.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSoft.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IManagerContract _managerContract;
        private readonly IMapper _mapper;

        public UserController(IManagerContract managerContract, IMapper mapper)
        {
            this._managerContract = managerContract ?? throw new ArgumentNullException(nameof(managerContract));
            this._mapper = mapper;
        }

        [HttpPost("Add-User")]
        public async Task<IActionResult> AddUser([FromBody] UserDTO user )
        {
           if(user is null)
            {
                return BadRequest("No Data");
            }
            var NewUser = _mapper.Map<User>(user);
            var creteduser = _managerContract.UserContract.Create(NewUser);
             await _managerContract.SaveAsync();

            return Ok(creteduser);
        } 


        [HttpGet("Get-All-User")]
        public async Task<IActionResult> GetAllUser()
        {
            var users =  _managerContract.UserContract.FindAll(true);
            return Ok(users);
        }
    }
}
