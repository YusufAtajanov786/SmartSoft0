using Contracts;
using Entities;
using Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepo: BaseRepo<User>,IUserContract
    {
        private readonly RepoContext _repoContext;

        public UserRepo(RepoContext repoContext)
            :base(repoContext)
        {
            this._repoContext = repoContext;
        }
    }
}
