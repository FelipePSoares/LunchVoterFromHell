using Entities;
using Repository.Repository.Contracts;
using System;

namespace Repository.Repository
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(IDataContext context) : base(context) { }

        //TODO: Implementar a troca de nome
        public virtual Group ChangeName(Group group)
        {
            //this.Context.Persons
            throw new NotImplementedException();
        }
    }
}