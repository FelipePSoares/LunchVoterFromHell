using Business.Contracts;
using Entities;
using Repository.Repository.Contracts;
using System;

namespace Business
{
    public class GroupBO : IGroupBO
    {
        private IGroupRepository groupRepository;
        
        public GroupBO(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        public Group ChangeName(Group group, Person owner)
        {
            this.ChangeNameIsPossible(group, owner);
            
            // 2. Add on Repository
            this.groupRepository.ChangeName(group);

            return group;
        }

        protected virtual void ChangeNameIsPossible(Group group, Person owner)
        {
            if (group.NameIsValid())
                throw new ArgumentException("Group name is not valid", "Name");

            if (this.GroupIsValid(group))
                throw new ArgumentException("Group is not valid", "Group");

            if (this.ThisPersonIsOwner(group, owner))
                throw new ArgumentException("This person does not Own", "Owner");
        }

        // TODO: Implementar validação
        protected virtual bool GroupIsValid(Group group)
        {
            throw new NotImplementedException();
        }

        // TODO: Implementar validação
        private bool ThisPersonIsOwner(Group group, Person owner)
        {
            throw new NotImplementedException();
        }
    }
}
