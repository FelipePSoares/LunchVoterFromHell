using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Contracts
{
    public interface IGroupRepository : IGenericRepository
    {
         Group ChangeName(Group group);
    }
}
