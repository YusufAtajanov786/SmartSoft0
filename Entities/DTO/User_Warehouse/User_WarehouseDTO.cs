using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.User_Warehouse
{
    public class User_WarehouseDTO
    {
        public List<WareDto> UserOfWarehouses { get; set; }
    }

    public class WareDto
    {
        public int WarehouseId { get; set; }
        public string Name { get; set; }
        
        public string Adress { get; set; }
    }
}
