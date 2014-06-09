using DomainService.Contracts;
using Entities;
using Repository.Repository;
using Repository.Repository.Contracts;
using System;

namespace DomainService
{
    public class GroupBO : IGroupBO
    {
        public IGroupRepository repository { get; set; }

        public GroupBO(IGroupRepository repository)
        {
            this.repository = repositoryd;
        }

        #region Crud

        //TODO: Implementar
        public void Add(Group group)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Utilities

        public Group ChangeName(Group group, Person owner)
        {
            this.ChangeNameIsPossible(group, owner);

            group = repository.ChangeName(group);

            return group;
        }

        public void AddParticipant(Group group, Person newPerson)
        {

        }

        #endregion
        
        #region Validation

        protected virtual void ChangeNameIsPossible(Group group, Person owner)
        {
            if (!group.NameIsValid())
                throw new ArgumentException("Group name is not valid.", "Name");

            if (!this.GroupIsValid(group))
                throw new ArgumentException("Group is not valid.", "Group");

            if (!this.ThisPersonIsOwner(group, owner))
                throw new ArgumentException("This person does not Own.", "Owner");
        }

        protected virtual bool GroupIsValid(Group group)
        {
            var recoveredGroup = repository.GetByID<Group>(group.Id);

            if (recoveredGroup == null)
                return false;

            return true;
        }

        private bool ThisPersonIsOwner(Group group, Person owner)
        {
            var recoveredGroup = repository.GetByID<Group>(group.Id);
            var recoveredOwner = repository.GetByID<Person>(owner.Id);

            if (recoveredGroup == null)
                return false;
                
            if (recoveredGroup.Owner.Id != recoveredOwner.Id)
                return false;

            return true;
        }

        #endregion
    }
}