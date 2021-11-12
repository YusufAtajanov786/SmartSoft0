using Contracts;
using Entities;
using Entities.DTO.User_Warehouse;
using Entities.Model.User_Warehouse;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class User_WarehouseRepo : BaseRepo<User_Warehouse>, IUser_WarehouseContract
    {
        private readonly RepoContext _repoContext;

        public User_WarehouseRepo(RepoContext repoContext)
            :base(repoContext)
        {
            this._repoContext = repoContext;
        }
        public async Task<List<WareDto>> GetUserOfWarehousesByUserId(int userId)
        {
           /* var respond =  _repoContext.User_Warehouses.Where(x => x.UserId == userId)
                .Select(x => new User_WarehouseDTO()
                {
                    UserOfWarehouses = x.Warehouse.User_Warehouses.Select(x=> new WareDto()
                    {
                        WarehouseId = x.WarehouseId,
                        Name = x.Warehouse.Name,
                        Adress = x.Warehouse.Adress
                    }).ToList()
                }).SingleOrDefault();*/
           
           // var res0 = _repoContext.User.Include(p => p.FirstName).ThenInclude(c => c.)

            var res = from n in _repoContext.User_Warehouses where n.UserId == userId
                      select  new WareDto() {
                          WarehouseId = n.WarehouseId,
                          Name = n.Warehouse.Name,
                          Adress = n.Warehouse.Adress
                      } ;
            return res.ToList();
        }
    }
}
