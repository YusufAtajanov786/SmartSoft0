using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IManagerContract
    {
        IUserContract UserContract { get; }

        IWarehouseContract Warehouse { get; }

        IUser_WarehouseContract user_WarehouseContract { get; }

        Task SaveAsync();
    }
}
