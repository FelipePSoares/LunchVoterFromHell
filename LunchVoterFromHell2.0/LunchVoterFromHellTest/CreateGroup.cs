using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using System.Collections.Generic;
using DomainService;
using Repository;
using Repository.Repository;
using Moq;

namespace LunchVoterFromHellTest
{
    [TestClass]
    public class CreateGroup : ObjectFactory
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
            this.GroupDomainService = this.GroupDomainServiceFactory();
        }

        [TestMethod]
        public void MustCreateGroup()
        {
            var group = new Group("Test", new Person("Test"), new List<Person>());
            group.Should().NotBeNull();
        }

        [TestMethod]
        public void MustCreateGroupAndHaveName()
        {
            Action newInstance = () => new Group(string.Empty, new Person("Test"), new List<Person>());
            newInstance.ShouldThrow<ArgumentNullException>().Where(a => a.ParamName == "Name");
            newInstance.ShouldThrow<ArgumentNullException>().Where(a => a.Message.Contains("Name not entered."));
        }

        [TestMethod]
        public void MustChangeNameGroup()
        {
            // Arrange
            var person = new Person("Test");
            var group = new Group("Test", person, new List<Person> { person });
            this.GroupRepositoryMock.Setup(e => e.ChangeName(It.IsAny<Group>())).Returns(group);

            // Act
            group.Name = "new Test";
            group = this.GroupDomainService.ChangeName(group, person);

            //Assert
            group.Name.Should().Be("new Test");
        }

        [TestMethod]
        public void MustChangeGroupNameIfYouIsOwner()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustEditGroupAndHaveOwner()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustDeleteGroup()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustAddOthersPeopleOnGroup()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustAddOthersPeopleOnGroupAndHaveOnlyOneOwner()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustChangeOwner()
        {
            Assert.Inconclusive();
        }
    }
}
