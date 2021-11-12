using AutoMapper;
using Contracts;
using Entities.DTO.Warehouse;
using Entities.Model.Warehouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSoft.Controllers
{
    [Route("api/warehouse")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IManagerContract _managerContract;
        private readonly IMapper _mapper;

        public WarehouseController(IManagerContract managerContract, IMapper mapper)
        {
            this._managerContract = managerContract ?? throw new ArgumentNullException(nameof(managerContract));
            this._mapper = mapper;
        }


        [HttpGet("Get-all-warehouse")]
        public IActionResult GetAllWarehouse()
        {
            return  Ok(_managerContract.Warehouse.FindAll(false));
        }


        [HttpPost("Add-warehouse")]
        public async Task<IActionResult> AddWarehouse([FromBody] WarehouseDTO warehouse )
        {
            if(warehouse == null)
            {
                return BadRequest("No Data");
            }
            var NewWarehouse = _mapper.Map<Warehouse>(warehouse);
            NewWarehouse.Status = true;
            var CreatedWarehouse =_managerContract.Warehouse.Create(NewWarehouse);
            await _managerContract.SaveAsync();
            return Ok(CreatedWarehouse);
        }
    }
}
