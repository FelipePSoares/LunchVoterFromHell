using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Group
    {
        public Group(string name, Person owner, List<Person> participants)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Name not entered.", "Name");

            if (owner == null || String.IsNullOrEmpty(owner.Name))
                throw new ArgumentException("Group not entered.", "Group");

            this.Name = name;
            this.Owner = owner;
            this.Participants = participants;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Person Owner { get; set; }

        public List<Person> Participants { get; set; }

        // TODO: Implementar validação
        public bool NameIsValid()
        {
            return true;
        }
    }
}