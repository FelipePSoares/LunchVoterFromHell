using Entities;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LunchVoterFromHellTest
{
    [TestClass]
    public class CreatePerson
    {
        /*[TestMethod]
        public void MustCreateGroupAndHaveOwner()
        {
            var group = new Group("Test");
            var person = new Person("Name", group, true);

            person.Group.Should().NotBeNull();
        }

        [TestMethod]
        public void MustCreateGroupAndNotHaveOwner()
        {
            var group = new Group("Test");
            Action newInstance = () => new Person("Name", null, true);

            newInstance.ShouldThrow<ArgumentNullException>().Where(a => a.ParamName == "Group");
            newInstance.ShouldThrow<ArgumentNullException>().Where(a => a.Message.Contains("Group not entered."));
        }*/
    }
}