using AutoMapper;
using Contracts;
using Entities.DTO.User_Warehouse;
using Entities.Model.User_Warehouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_WarehouseController : ControllerBase
    {
        private readonly IManagerContract _managerContract;
        private readonly IMapper _mapper;

        public User_WarehouseController(IManagerContract managerContract, IMapper mapper)
        {
            this._managerContract = managerContract ?? throw new ArgumentNullException(nameof(managerContract));
            this._mapper = mapper;
        }


        [HttpPost("Add-Connection-Btw-user-warehouse")]
        public async Task<IActionResult> AddConnectionBtwUserWarehouse([FromBody] User_WarehouseAddDTO data)
        {
            var user_warehouse = _mapper.Map<User_Warehouse>(data);
            var result =_managerContract.user_WarehouseContract.Create(user_warehouse);
            await _managerContract.SaveAsync();
            return Ok(result);
        }

        [HttpGet("Get-User-Of-Warehouses/{userId}")]
        public IActionResult GetUserOfWarehouses(int userId)
        {
            var respond = _managerContract.user_WarehouseContract.GetUserOfWarehousesByUserId(userId);
            return Ok(respond);
        }

    }
}
