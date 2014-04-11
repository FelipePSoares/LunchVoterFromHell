using Entities;
using Repository.Repository.Contracts;
using System;

namespace Repository.Repository
{
    public class GroupRepository : GenericRepository, IGroupRepository
    {
        //TODO: Implementar a troca de nome
        public virtual Group ChangeName(Group group)
        {
            throw new NotImplementedException();
        }
    }
}