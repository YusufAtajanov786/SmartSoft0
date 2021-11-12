using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ManagerRepo:IManagerContract
    {
        private readonly RepoContext _repoContext;
        private IUserContract userContract;
        private IWarehouseContract warehouseContract;
        private IUser_WarehouseContract _user_WarehouseContract;
        public ManagerRepo(RepoContext repoContext)
        {
            this._repoContext = repoContext ?? throw new ArgumentNullException(nameof(repoContext));
        }

        public IUserContract UserContract
        { 
            get
            {
                if(userContract == null)
                {
                    userContract = new UserRepo(_repoContext);
                }
                return userContract;
            }  
        }

        public IWarehouseContract Warehouse
        {
            get
            {
                if (warehouseContract == null)
                {
                    warehouseContract = new WarehouseRepo(_repoContext);
                }
                return warehouseContract;
            }
        }

        public IUser_WarehouseContract user_WarehouseContract
        {
            get
            {
                if (_user_WarehouseContract == null)
                {
                    _user_WarehouseContract = new User_WarehouseRepo(_repoContext);
                }
                return _user_WarehouseContract;
            }
        }

        public async Task SaveAsync()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
