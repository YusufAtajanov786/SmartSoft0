using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model.User_Warehouse
{
    public class User_Warehouse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User.User User { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse.Warehouse Warehouse { get; set; }
    }
}
