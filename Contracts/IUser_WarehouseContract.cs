using Entities;
using Entities.DTO.User_Warehouse;
using Entities.Model.User_Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUser_WarehouseContract:IBaseContract<User_Warehouse>
    {

        Task<List<WareDto>> GetUserOfWarehousesByUserId(int userId);
    }
}
